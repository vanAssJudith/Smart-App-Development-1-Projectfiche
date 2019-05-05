using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Models
{
    public class Result
    {
        [JsonProperty(propertyName: "results")]
        public List<Movie> Movies { get; set; }
    }
}
