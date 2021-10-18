using Newtonsoft.Json;
using OsuServerLauncher.Controls;
using OsuServerLauncher.Helpers;
using OsuServerLauncher.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsuServerLauncher
{
  public partial class MainForm : Form
  {
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    public static extern bool ReleaseCapture();

    List<Server> m_servers = new List<Server>() { Server.Official };
    Data m_data = new Data();
    ServerItem m_selectedServerItem = null;
    HttpListener m_httpListener = new HttpListener();
    string m_osuPath = "";

    string m_appdatafolder = Path.Combine(Environment.GetEnvironmentVariable("localappdata"), "osu! Server Launcher");
    string m_serverfile = Path.Combine(Environment.GetEnvironmentVariable("localappdata"), "osu! Server Launcher", "servers.json");
    string m_datafile = Path.Combine(Environment.GetEnvironmentVariable("localappdata"), "osu! Server Launcher", "data.json");

    string m_streamoverlayserverfile = Path.Combine(Environment.GetEnvironmentVariable("localappdata"), "osu! Server Launcher", "streamoverlay", "server.txt");
    string m_streamoverlayiconfile = Path.Combine(Environment.GetEnvironmentVariable("localappdata"), "osu! Server Launcher", "streamoverlay", "icon.png");

    public const string VERSION = "v1.0";

    public MainForm()
    {
      InitializeComponent();

      pnlLauncher.Show();
      pnlAbout.Hide();
      lblVersion.Text = $"Version {VERSION}";
    }

    private void btnExit_Click(object sender, EventArgs e) => Application.Exit();

    private void pctrGithub_Click(object sender, EventArgs e) => Process.Start(new ProcessStartInfo("cmd", $"/c start https://github.com/minisbett/osu-server-launcher") { CreateNoWindow = true });

    private void pctrDiscord_Click(object sender, EventArgs e) => Process.Start(new ProcessStartInfo("cmd", $"/c start https://discord.gg/9KfUdHpUA8") { CreateNoWindow = true });

    private void FormDraggable(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        ReleaseCapture();
        SendMessage(Handle, 0xA1, 0x2, 0);
      }
    }

    protected override CreateParams CreateParams
    {
      get
      {
        CreateParams cp = base.CreateParams;
        cp.ClassStyle |= 0x20000;
        return cp;
      }
    }

    private void btnLauncher_Click(object sender, EventArgs e)
    {
      btnLauncher.BackColor = Color.FromArgb(10, 10, 10);
      btnLauncher.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 10, 10);
      btnLauncher.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 10, 10);
      btnLauncher.FlatAppearance.BorderSize = 0;

      btnAbout.BackColor = Color.FromArgb(31, 31, 31);
      btnAbout.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 31, 31);
      btnAbout.FlatAppearance.MouseOverBackColor = Color.FromArgb(31, 31, 31);
      btnAbout.FlatAppearance.BorderSize = 2;

      pnlLauncher.Show();
      pnlAbout.Hide();
    }

    private void btnAbout_Click(object sender, EventArgs e)
    {
      btnAbout.BackColor = Color.FromArgb(10, 10, 10);
      btnAbout.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 10, 10);
      btnAbout.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 10, 10);
      btnAbout.FlatAppearance.BorderSize = 0;

      btnLauncher.BackColor = Color.FromArgb(31, 31, 31);
      btnLauncher.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 31, 31);
      btnLauncher.FlatAppearance.MouseOverBackColor = Color.FromArgb(31, 31, 31);
      btnLauncher.FlatAppearance.BorderSize = 2;

      pnlAbout.Show();
      pnlLauncher.Hide();
    }

    private async void MainForm_Load(object sender, EventArgs e)
    {
      await Task.Delay(1);

      Directory.CreateDirectory(m_appdatafolder);
      Directory.CreateDirectory(Path.Combine(m_appdatafolder, "streamoverlay"));

      File.WriteAllText(Path.Combine(m_appdatafolder, "DO NOT SHARE THE 'servers.json' FILE."), "The servers.json file may contain credentials from accounts on servers you play.\nDo not share this file with anyone.");
      
      if (!File.Exists(m_serverfile))
        File.WriteAllText(m_serverfile, JsonConvert.SerializeObject(m_servers, Formatting.Indented));
      m_servers = JsonConvert.DeserializeObject<Server[]>(File.ReadAllText(m_serverfile)).ToList();

      if (!File.Exists(m_datafile))
        File.WriteAllText(m_datafile, JsonConvert.SerializeObject(m_data, Formatting.Indented));
      m_data = JsonConvert.DeserializeObject<Data>(File.ReadAllText(m_datafile));

      m_osuPath = Utils.GetOsuPath();
      if (m_osuPath == "")
      {
        m_osuPath = m_data.AlternativeOsuPath;
        bool retry = false;
        do
        {
          if (retry)
            MessageBox.Show("The selected folder could not be identified as your osu! folder. Please select the correct folder.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
          else
            MessageBox.Show("Could not detect your osu! installation path.\nPlease select your osu! folder in the following dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
          FolderBrowserDialog fbd = new FolderBrowserDialog();
          if (fbd.ShowDialog() != DialogResult.OK)
          {
            Application.Exit();
            return;
          }

          m_osuPath = fbd.SelectedPath;
          retry = true;
        }
        while (m_osuPath == "" || !File.Exists(Path.Combine(m_osuPath, "osu!.exe")));

        m_data.AlternativeOsuPath = m_osuPath;
        File.WriteAllText(m_datafile, JsonConvert.SerializeObject(m_data, Formatting.Indented));
      }

      File.WriteAllText(m_streamoverlayserverfile, "");
      File.WriteAllText(m_streamoverlayiconfile, "");

      UpdateServerList();

#pragma warning disable CS4014
      Task.Run(async () =>
      {
        string newestversion = await GetNewestVersion();
        if (newestversion != VERSION)
          MessageBox.Show($"A new version is available!\n\nYour Version: {VERSION}\nNewest Version: {newestversion}\n\nPlease download the newest version from GitHub to prevent bugs and grant the best user experience.\nYou can find the GitHub Repository on the \"About\" page of the launcher.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
      });
#pragma warning restore CS4014
    }

    private async Task<string> GetNewestVersion()
    {
      using (HttpClient client = new HttpClient())
      {
        client.DefaultRequestHeaders.UserAgent.TryParseAdd("request");
        HttpResponseMessage response = await client.GetAsync("https://api.github.com/repos/minisbett/osu-server-launcher/releases?per_page=1");
        string[] split = (await response.Content.ReadAsStringAsync()).Split('"');

        if (split.Length == 1)
          return VERSION;

        return split[split.ToList().IndexOf("tag_name") + 2];
      }
    }

    private void UpdateServerList()
    {
      flowLayoutPanel.Controls.Clear();
      foreach (Server server in m_servers)
      {
        ServerItem item = new ServerItem(server);
        item.Click += ServerItemClick;
        item.DoubleClick += ServerItemDoubleClick;
        item.ShowLock = server.Credentials != null;
        flowLayoutPanel.Controls.Add(item);
      }
    }

    private void ServerItemClick(ServerItem sender)
    {
      m_selectedServerItem?.DeselectItem();
      sender.SelectItem();
      m_selectedServerItem = sender;
      btnRemoveServer.Enabled = true;
      btnAddRemoveCredentials.Enabled = true;
      btnAddRemoveCredentials.Text = sender.Server.Credentials == null ? "Add Credentials" : "Remove Credentials";
    }

    private void ServerItemDoubleClick(ServerItem sender)
    {
      Server server = sender.Server;

      string configfile = File.ReadAllText(Path.Combine(m_osuPath, $"osu!.{Environment.UserName}.cfg"));
      if (server.Credentials != null)
      {
        string endpointline = configfile.Replace("\r", "").Split('\n').FirstOrDefault(x => x.Split("=".ToCharArray(), 2)[0].TrimEnd() == "CredentialEndpoint");
        string usernameline = configfile.Replace("\r", "").Split('\n').FirstOrDefault(x => x.Split("=".ToCharArray(), 2)[0].TrimEnd() == "Username");
        string passwordline = configfile.Replace("\r", "").Split('\n').FirstOrDefault(x => x.Split("=".ToCharArray(), 2)[0].TrimEnd() == "Password");
        configfile = configfile.Replace($"\n{endpointline}", $"\nCredentialEndpoint = {(server.IsOfficial ? "" : server.Domain)}");
        configfile = configfile.Replace($"\n{usernameline}", $"\nUsername = {server.Credentials.Username}");
        configfile = configfile.Replace($"\n{passwordline}", $"\nPassword = {server.Credentials.Password}");
        File.WriteAllText(Path.Combine(m_osuPath, $"osu!.{Environment.UserName}.cfg"), configfile);
      }

      Process.Start(Path.Combine(m_osuPath, "osu!.exe"), server.IsOfficial ? "" : $"-devserver {server.Domain}");

      File.WriteAllText(m_streamoverlayserverfile, server.Name);
      if (sender.Icon != null)
        sender.Icon.Save(m_streamoverlayiconfile, ImageFormat.Png);
      else
        File.WriteAllText(m_streamoverlayiconfile, "");
    }

    private void btnAddServer_Click(object sender, EventArgs e)
    {
      AddServer add = new AddServer();
      add.ShowDialog();
      if (add.Server != null)
      {
        if (m_servers.Any(x => x.Domain == add.Server.Domain))
        {
          MessageBox.Show($"A server with the domain '{add.Server.Domain}' already exists in your server list.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }

        m_servers.Add(add.Server);
        File.WriteAllText(m_serverfile, JsonConvert.SerializeObject(m_servers, Formatting.Indented));
        UpdateServerList();
      }
    }

    private void btnRemoveServer_Click(object sender, EventArgs e)
    {
      m_servers.Remove(m_selectedServerItem.Server);
      File.WriteAllText(m_serverfile, JsonConvert.SerializeObject(m_servers, Formatting.Indented));
      btnRemoveServer.Enabled = false;
      btnAddRemoveCredentials.Enabled = false;
      m_selectedServerItem = null;
      UpdateServerList();
    }

    private void btnAddRemoveCredentials_Click(object sender, EventArgs e)
    {
      if (btnAddRemoveCredentials.Text == "Add Credentials")
      {
        AddCredentials ac = new AddCredentials();
        ac.ShowDialog();
        if (ac.Credentials == null)
          return;

        m_servers.First(x => x.Domain == m_selectedServerItem.Server.Domain).Credentials = ac.Credentials;
        m_selectedServerItem.ShowLock = true;
        File.WriteAllText(m_serverfile, JsonConvert.SerializeObject(m_servers, Formatting.Indented));

        btnAddRemoveCredentials.Text = "Remove Credentials";
      }
      else
      {
        m_servers.First(x => x.Domain == m_selectedServerItem.Server.Domain).Credentials = null;
        m_selectedServerItem.ShowLock = false;
        File.WriteAllText(m_serverfile, JsonConvert.SerializeObject(m_servers, Formatting.Indented));

        btnAddRemoveCredentials.Text = "Add Credentials";
      }
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      File.WriteAllText(m_streamoverlayserverfile, "");
      File.WriteAllText(m_streamoverlayiconfile, "");
    }
  }
}
