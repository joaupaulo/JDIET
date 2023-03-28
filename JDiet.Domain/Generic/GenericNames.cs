using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace JDiet.Domain.Generic
{
    public class GenericNames
    {
        [BsonId]
        public ObjectId _Id { get; set; }

        public string Name { get; set; }
        public int Cpf { get; set; }
        public string Sex { get; set; }
        public int NumberPhone { get; set; }
        public int Adress { get; set; }

        public GenericNames()
        {
            _Id = ObjectId.GenerateNewId();
        }
    }
}