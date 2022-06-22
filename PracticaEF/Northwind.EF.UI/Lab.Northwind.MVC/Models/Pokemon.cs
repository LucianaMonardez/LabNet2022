using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Northwind.MVC.Models
{
    public class Pokemon
    {
        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("stats")]
        public List<object> Stats { get; set; }

        [JsonProperty("types")]
        public List<Type> Types { get; set; }

        [JsonProperty("weight")]
        public long Weight { get; set; }
    }
}