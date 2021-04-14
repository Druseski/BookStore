using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BookStore.Entities.Quotes
{
    public class Quote
    {
        [JsonPropertyName("tags")]

        public List<string> Tags { get; set; }

        public string quote { get; set; }

        [JsonPropertyName("lang")]

        public string Language { get; set; }

        [JsonPropertyName("author")]

        public string Author { get; set; }

    }
}