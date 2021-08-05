using OsuServerLauncher.Helpers;
using OsuServerLauncher.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsuServerLauncher.Controls
{
  public partial class AddCredentials : Form
  {
    [DllImport("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
    [DllImport("user32.dll")]
    public static extern bool ReleaseCapture();

    public Credentials Credentials { get; private set; }

    public AddCredentials()
    {
      InitializeComponent();
    }

    private void btnExit_Click(object sender, EventArgs e) => Close();

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

    private void btnAddServer_Click(object sender, EventArgs e)
    {
      string password = DPAPI.Encrypt(DPAPI.KeyType.UserKey, txtPassword.Text, "cu24180ncjeiu0ci1nwui", "Raw");
      Credentials = new Credentials(txtUsername.Text, password);
      Close();
    }

    private void txt_TextChanged(object sender, EventArgs e)
    {
      btnAddCredentials.Enabled = txtUsername.TextLength > 0 && txtPassword.TextLength > 0;
    }

    private void txt_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
        btnAddCredentials.PerformClick();
    }
  }
}
