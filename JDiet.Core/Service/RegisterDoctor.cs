using JDiet.Domain.Entity;
using JDiet.Domain.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDiet.Core.Service
{
    public class RegisterDoctor
    {
        public MedicalRegister RegisterPerfilDoctor(MedicalRegister register)
        {
            AddNameDoctor(register);
            AddCpfDoctor(register);
            AddCepDoctor(register);
            AddNumberDoctor(register);
            return register;
        }

        private static void AddNameDoctor(MedicalRegister register)
        {
            Console.WriteLine("Por favor, Doutor digite o seu nome");
            string nameDoctor = Console.ReadLine();
            register.Name = nameDoctor;
            Console.Clear();
        }

        private static void AddCpfDoctor(MedicalRegister register)
        {
            Console.WriteLine("Por favor, Doutor digite o seu Cpf");
            int cpfDoctor = int.Parse(Console.ReadLine());
            register.Cpf = cpfDoctor;
            Console.Clear();
        }

        private static void AddCepDoctor(MedicalRegister register)
        {
            Console.WriteLine("Por favor, Doutor digite o seu CEP");
            int cepDoctor = int.Parse(Console.ReadLine());
            register.Cpf = cepDoctor;
            Console.Clear();
        }

        private static void AddNumberDoctor(MedicalRegister register)
        {
            Console.WriteLine("Por favor, Doutor digite o seu Número de Celular");
            int NumberDoctor = int.Parse(Console.ReadLine());
            register.NumberPhone = NumberDoctor;
            Console.Clear();
        }
    }
}