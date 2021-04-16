using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BookStore.Entities.Quotes
{
    public class QuoteMap
    {
        [Key]
        public int Id { get; set; }

        public string Tags { get; set; }

        public string Quote { get; set; }

        public string Language { get; set; }

        public string Author { get; set; }

    }
}