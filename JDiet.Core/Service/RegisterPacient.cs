using JDiet.Domain.Entity;

namespace JDiet.Core.Service
{
    public class RegisterPacient
    {
        public MedicalPatient RegisterPacientMedical(MedicalPatient medicalPatient)
        {
            Console.WriteLine("Olá vamos dar proceguimento ao seu cadastro");
            AddNamePacientMedical(medicalPatient);
            AddCpfPacientMedical(medicalPatient);
            AddSexPacientMedical(medicalPatient);
            AddNumberPacientMedical(medicalPatient);
            AddCepPacientMedical(medicalPatient);
            return medicalPatient;
        }

        private static void AddCepPacientMedical(MedicalPatient medicalPatient)
        {
            Console.WriteLine("Digite o seu CEP");
            int cepPacient = int.Parse(Console.ReadLine());
            medicalPatient.Adress = cepPacient;
            Console.Clear();
        }

        private static void AddNumberPacientMedical(MedicalPatient medicalPatient)
        {
            Console.WriteLine("Digite o seu Número de celular");
            int numberPacient = int.Parse(Console.ReadLine());
            medicalPatient.NumberPhone = numberPacient;
            Console.Clear();
        }

        private static void AddSexPacientMedical(MedicalPatient medicalPatient)
        {
            Console.WriteLine("Digite o seu Sexo");
            string sexPacient = Console.ReadLine();
            medicalPatient.Sex = sexPacient;
            Console.Clear();
        }

        private static void AddCpfPacientMedical(MedicalPatient medicalPatient)
        {
            Console.WriteLine("Digite o seu CPF");
            int cpfPacient = int.Parse(Console.ReadLine());
            medicalPatient.Cpf = cpfPacient;
            Console.Clear();
        }

        private static void AddNamePacientMedical(MedicalPatient medicalPatient)
        {
            Console.WriteLine("Digite o seu nome");
            string namePacient = Console.ReadLine();
            medicalPatient.Name = namePacient;
            Console.Clear();
        }
    }
}