using JDiet.Domain.Generic;

namespace JDiet.Domain.Entity
{
    public class MedicalRegister : GenericNames
    {
        private int MedicalCrmNumber { get; set; }
        private string MedicalSpeciality { get; set; }
        private string OccupationArea { get; set; }

        public void InsertMedicalCrmNumber(int MedicalCrmNumber) => this.MedicalCrmNumber = MedicalCrmNumber;

        public void InsertMedicalSpeciality(string MedicalSpeciality) => this.MedicalSpeciality = MedicalSpeciality;

        public void InsertOccupationArea(string OccupationArea) => this.OccupationArea = OccupationArea;
    }
}