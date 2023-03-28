using JDiet.Domain.Entity;
using JDiet.Repository.Repository.Interface;
using MongoDB.Bson;
using MongoDB.Driver;

namespace JDiet.Repository.Repository
{
    public class MongoClientRepository : IMongoClientRepository
    {
        private readonly string _connectionstring;

        public MongoClientRepository()
        {
            _connectionstring = "mongodb+srv://joaopaulo123:1799jp@cluster0.8rok3.mongodb.net/?authSource=admin";
        }

        private IMongoCollection<MedicalPatient> ConnectionString()
        {
            var client = new MongoClient(_connectionstring);

            var collection = client.GetDatabase("JDiet").GetCollection<MedicalPatient>("MedicalPatient");

            return collection;
        }

        public void InsertInCollection(MedicalPatient Insert)
        {
            ConnectionString().InsertOne(Insert);
        }

        public void DeleteInCollection(MedicalPatient Insert)
        {
            var filter = Builders<MedicalPatient>.Filter.Eq(Patient => Patient.Cpf, Insert.Cpf);
            ConnectionString().DeleteOne(filter);
        }

        public void UpdateInCollection(MedicalPatient Insert)
        {
            var filter = Builders<MedicalPatient>.Filter.Eq(Patient => Patient.Cpf, Insert.Cpf);
            var update = Builders<MedicalPatient>.Update.Set(Patient => Patient.Cpf, Insert.Cpf);

            ConnectionString().UpdateOne(filter, update);
        }

        public void InsertInCollection(MedicalRegister Insert)
        {
            throw new NotImplementedException();
        }
    }
}