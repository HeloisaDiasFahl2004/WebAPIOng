using MongoDB.Bson.Serialization.Attributes;

namespace WebAPIOng.Models
{
    public class Adotante
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public Pet PetId { get; set; }

    }
}
