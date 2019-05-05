using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project.Models
{
    public class Movie
    {
        //props
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        [JsonProperty(propertyName: "vote_average")]
        public float VoteAverage { get; set; }
        [JsonProperty(propertyName: "poster_path")]
        public string PosterPath { get; set; }
        [JsonProperty(propertyName: "release_date")]
        public string ReleaseDate { get; set; }
    }



}

