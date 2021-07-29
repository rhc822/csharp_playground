using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WebAPIClient
{
    public class WeatherAPIRepo
    {
        public Location location { get; set; }

    }


    public class Location
    {
        public string name { get; set; }
        public string region { get; set; }
        public string country { get; set; }
        public float lat { get; set; }
        public float lon { get; set; }
        public string tz_id { get; set; }
        public int localtime_epoch { get; set; }
        public string localtime { get; set; }
    }



  /*  
    class HTTPTutorialRepository
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("html_url")]
        public Uri GitHubHomeUrl { get; set; }
        [JsonPropertyName("homepage")]
        public Uri Homepage { get; set; }
        [JsonPropertyName("watchers")]
        public int Watchers { get; set; }
        [JsonPropertyName("pushed_at")]
        public DateTime LastPushUtc { get; set; }
        //public DateTime LastPush => LastPushUtc.ToLocalTime();
    }
   */



}
