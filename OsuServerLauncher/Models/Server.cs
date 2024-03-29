﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsuServerLauncher.Models
{
  public class Server
  {
    [JsonProperty("name")]
    public string Name { get; private set; }

    [JsonProperty("domain")]
    public string Domain { get; private set; }

    [JsonProperty("credentials")]
    public Credentials Credentials { get; set; }

    [JsonIgnore]
    public bool IsOfficial => Domain == Official.Domain;

    public static Server Official => new Server("Official", "osu.ppy.sh");

    public Server(string name, string domain)
    {
      Name = name;
      Domain = domain;
    }
  }
}
