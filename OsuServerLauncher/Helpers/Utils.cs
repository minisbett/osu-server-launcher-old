using Microsoft.Win32;
using OsuServerLauncher.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OsuServerLauncher.Helpers
{
  public static class Utils
  {
    public static Image GetServerIcon(string domain)
    {
      WebClient client = new WebClient();

      if(domain == "ppy.sh")
        try
        {
          return Image.FromStream(new MemoryStream(client.DownloadData("https://raw.githubusercontent.com/MinisBett/osu-server-launcher/master/osu_1024.png"))); 
        }
        catch { }

      string[] urls = new string[]
      {
        $"https://osu.{domain}/favicon.ico",
        $"https://osu.{domain}/static/favicon.ico",
        $"https://{domain}/favicon.ico",
        $"https://{domain}/static/favicon.ico"
      };

      foreach (string url in urls)
        try
        {
          Image img = Image.FromStream(new MemoryStream(client.DownloadData(url)));
          if (img.Width != img.Height)
            continue;
          if (img.Width < 64)
          {
            Image img2 = new Bitmap(64, 64);
            using (Graphics g = Graphics.FromImage(img2))
              g.DrawImage(img, 64 / 2 - img.Width / 2, 64 / 2 - img.Height / 2);
            img.Dispose();
            return img2;
          }

          return img;
        }
        catch { }

      return null;
    }

    public static string GetOsuPath()
    {
      if (File.Exists(Path.Combine(Environment.GetEnvironmentVariable("localappdata"), "osu!", "osu!.exe")))
        return Path.Combine(Environment.GetEnvironmentVariable("localappdata"), "osu!");

      try
      {
        // "F:\\osu!\\osu.exe",1
        string osuexe = Registry.GetValue("HKEY_CLASSES_ROOT\\osu\\DefaultIcon", "", "").ToString();
        osuexe = osuexe.Substring(1, osuexe.Length - 4);

        string osudir = new FileInfo(osuexe).DirectoryName;

        // exclude possible custom clients (folder or exe not named "osu!")
        if (new DirectoryInfo(osudir).Name != "osu!" || !File.Exists(Path.Combine(osudir, "osu!.exe")))
          return "";

        return osudir;
      }
      catch { }

      return "";
    }
  }
}
