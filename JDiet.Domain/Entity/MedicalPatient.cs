using JDiet.Domain.Generic;

namespace JDiet.Domain.Entity
{
    public class MedicalPatient : GenericNames
    {
        private string MedicalDescription { get; set; }
        private string Comments { get; set; }

        public void InsertDescription(string Description)
        {
            this.MedicalDescription = Description;
        }

        public void InsetComments(string Comments)
        {
            this.Comments = Comments;
        }
    }
}