using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public class Podcast
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Namn { get; set; }
        public string Beskrivning { get; set; }
        public string RssUrl { get; set; } 
        public List<Avsnitt> Avsnitt { get; set; }
        public string KategoriId { get; set; }


    }
}
