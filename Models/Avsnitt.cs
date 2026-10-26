using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public class Avsnitt
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string PodcastId { get; set; }
        public string Titel { get; set; }
        public string Beskrivning { get; set; }
        public DateTime Publiceringsdatum { get; set; }
    }
}
