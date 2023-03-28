using JDiet.Domain.Entity;
using JDiet.Repository.Repository.Interface;

namespace JDiet.Core.Service
{
    public class ProcessService
    {
        private readonly IMongoClientRepository _imongoClientRepository;

        public ProcessService(IMongoClientRepository mongoClientRepository)
        {
            _imongoClientRepository = mongoClientRepository;
        }

        public void ProcessAppointment()
        {
            Console.WriteLine("Olá sejam bem-vindo a JDIET, você é um dos nossos médicos ou deseja realizar uma consulta?");
            Console.WriteLine("Caso queira realizar uma consulta Digite 1");
            Console.WriteLine("Caso seja um dos nossos médicos Digite 2");
            int opcaoMenu = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcaoMenu)
            {
                case 1:
                    MedicalPatient MedicalPacientRegister = new MedicalPatient();
                    RegisterPacient Register = new RegisterPacient();
                    Register.RegisterPacientMedical(MedicalPacientRegister);
                    _imongoClientRepository.InsertInCollection(MedicalPacientRegister);
                    break;

                case 2:
                    MedicalRegister MedicalRegister = new MedicalRegister();
                    RegisterDoctor RegisterDoctor = new RegisterDoctor();
                    RegisterDoctor.RegisterPerfilDoctor(MedicalRegister);
                    _imongoClientRepository.InsertInCollection(MedicalRegister);
                    break;
            }
        }
    }
}