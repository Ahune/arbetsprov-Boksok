using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Arbetsprov_BokSok.Models
{

    public class Book
    {
        public Book(string id, string author, string title, string genre, string price, DateTime publish, string description)
        {
            Id = id;
            Author = author;
            Title = title;
            Genre = genre;
            Price = price;
            Publish = publish;
            Description = description;
        }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "author")]
        public string Author { get; set; }
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        [JsonProperty(PropertyName = "genre")]
        public string Genre { get; set; }
        [JsonProperty(PropertyName = "price")]
        public string Price { get; set; }
        [JsonProperty(PropertyName = "publish_date")]
        public DateTime Publish { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}