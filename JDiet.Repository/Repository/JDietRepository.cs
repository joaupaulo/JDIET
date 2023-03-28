using JDiet.Domain.Entity;
using JDiet.Repository.Repository.Interface;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDiet.Repository.Repository
{
    public class JDietRepository : IJDietRepository
    {
        private readonly IMongoClientRepository _imongoClientRepository;

        public JDietRepository(IMongoClientRepository imongoClientRepository)
        {
            _imongoClientRepository = imongoClientRepository;
        }

        public void InsertDocuments(MedicalPatient medicalShedule)
        {
            _imongoClientRepository.InsertInCollection(medicalShedule);
            Console.WriteLine("Its OK");
        }
    }
}