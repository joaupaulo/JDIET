using JDiet.Domain.Entity;
using JDiet.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDiet.Core.Service
{
    public class MakeAnAppointmentService
    {
        private readonly IJDietRepository _ijDietRepository;

        public MakeAnAppointmentService(IJDietRepository jDietRepository)
        {
            _ijDietRepository = jDietRepository;
        }

        public void MakeAppointment(MedicalPatient scheduleMedical)
        {
            _ijDietRepository.InsertDocuments(scheduleMedical);
        }
    }
}