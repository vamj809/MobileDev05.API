using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MobileDev05.API.Models
{
    public class RecipeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class RecipeHits
    {
        [JsonProperty("recipe")]
        public RecipeItem Recipe { get; set; }
    }

    public class RecipeSearchResults
    {
        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("hits")]
        public ObservableCollection<RecipeHits> Hits { get; set; }
    }
}
