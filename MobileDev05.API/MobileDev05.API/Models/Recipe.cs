using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileDev05.API.Models
{
    public class Recipe
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
