using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Models
{
    public class VideoResult
    {
        [JsonProperty(propertyName: "results")]
        public List<Video> Videos { get; set; }
    }
}
