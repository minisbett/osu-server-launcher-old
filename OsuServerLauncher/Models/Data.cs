using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsuServerLauncher.Models
{
  public class Data
  {
    [JsonProperty("alternative_osu_path")]
    public string AlternativeOsuPath { get; set; } = "";
  }
}
