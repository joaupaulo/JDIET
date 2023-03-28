using JDiet.Repository.Repository.Interface;
using JDiet.Repository.Repository;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using JDiet.Core.Service;

namespace JDiet.Consultorio
{
    public class Program
    {
        public static int Main(string[] args)
        {
            try
            {
                MongoClientRepository mongoClientRepository = new MongoClientRepository();
                ProcessService processAppointmentt = new ProcessService(mongoClientRepository);
                processAppointmentt.ProcessAppointment();
                HostBuilder();
                return 0;
            }
            catch
            {
                return 1;
            }
            finally
            {
                Console.WriteLine("Goddaammmm!");
            }
        }

        public static void HostBuilder()
        {
            IHost _host = Host.CreateDefaultBuilder().ConfigureServices(services =>
            { services.AddSingleton<IMongoClientRepository, MongoClientRepository>(); })
                  .Build();
        }
    }
}