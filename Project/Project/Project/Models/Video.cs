using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Models
{
    public class Video
    {
        public string Id { get; set; }
        [JsonProperty(propertyName: "key")]
        public string Key { get; set; }
        [JsonProperty(propertyName: "site")]
        public string Site { get; set; }
        [JsonProperty(propertyName: "type")]
        public string Type { get; set; }

    }
}
