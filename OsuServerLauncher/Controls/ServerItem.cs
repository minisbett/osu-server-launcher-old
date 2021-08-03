using OsuServerLauncher.Helpers;
using OsuServerLauncher.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsuServerLauncher.Controls
{
  public partial class ServerItem : UserControl
  {

    public static Dictionary<string, Image> IconCache { get; } = new Dictionary<string, Image>();

    public Server Server { get; }

    public bool ShowLock { set => pictureLock.Visible = value; }

    public Image Icon => pictureIcon.Image;

    public delegate void ClickHandler(ServerItem sender);
    public new event ClickHandler Click;
    public new event ClickHandler DoubleClick;

    public ServerItem(Server server)
    {
      InitializeComponent();

      Server = server;
      lblName.Text = server.Name;
      if (IconCache.ContainsKey(server.Domain))
        pictureIcon.Image = IconCache[server.Domain];
      else
        FetchIcon(SynchronizationContext.Current);

      base.Click += (sender, e) => Click?.Invoke(this);
      base.DoubleClick += (sender, e) => DoubleClick?.Invoke(this);
      foreach(Control c in Controls)
      {
        c.Click += (sender, e) => Click?.Invoke(this);
        c.DoubleClick += (sender, e) => DoubleClick?.Invoke(this);
      }

      pictureLock.Parent = pictureIcon;
    }

    public void SelectItem()
    {
      BackColor = Color.FromArgb(30, 30, 30);
    }

    public void DeselectItem()
    {
      BackColor = Color.FromArgb(10, 10, 10);
    }

    private async void FetchIcon(SynchronizationContext context)
    {
      await Task.Run(async () =>
      { 
        Image img = Utils.GetServerIcon(Server.Domain);
        if (img != null)
        {
          context.Post(_ => pictureIcon.Image = img, null);
          IconCache.Add(Server.Domain, img);
        }
      });
    }
  }
}
