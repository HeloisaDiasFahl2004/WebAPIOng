using MongoDB.Bson.Serialization.Attributes;

namespace WebAPIOng.Models
{
    public class Pet
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Raça { get; set; }
        public string Familia { get; set; }
        public string Sexo { get; set; }
        public string Name { get; set; }
        public string Situacao { get; set; }
    }
}
