using JDiet.Domain.Entity;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDiet.Repository.Repository.Interface
{
    public interface IMongoClientRepository
    {
        void InsertInCollection(MedicalRegister Insert);

        void InsertInCollection(MedicalPatient Insert);

        void DeleteInCollection(MedicalPatient Insert);

        void UpdateInCollection(MedicalPatient Insert);
    }
}