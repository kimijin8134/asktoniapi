using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections;

namespace AskToniApi.Models
{
    public class Recommendation
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("RestaurantName")]
        public string RestaurantName { get; set;}

        [BsonElement("ReviewCount")]
        public int ReviewCount { get; set;}

        [BsonElement("Rating")]
        public double Rating { get; set;}

        [BsonElement("Price")]
        public string Price { get; set;}
        [BsonElement("Address")]
        public string Address {get; set;}
        [BsonElement("City")]
        public string City {get; set;}
        [BsonElement("ZipCode")]
        public string ZipCode {get; set;}
        [BsonElement("Phone")]
        public string Phone { get; set;}
        [BsonElement("Categories")]
        public string[] Categories {get; set;}
    }
}