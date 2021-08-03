using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsuServerLauncher.Models
{
  public class Credentials
  {
    [JsonProperty("username")]
    public string Username { get; private set; }
  
    [JsonProperty("password")]
    public string Password { get; private set; }

    public Credentials(string username, string password)
    {
      Username = username;
      Password = password;
    }
  }
}
