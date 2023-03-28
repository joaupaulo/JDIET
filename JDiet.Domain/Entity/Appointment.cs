namespace JDiet.Domain.Entity
{
    public class Appointment
    {
        public DateTime AppointmentDay { get; set; }
        public DateTime AppointmentTime { get; set; }
        public MedicalRegister medical { get; set; }
    }
}