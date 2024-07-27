using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailService;

namespace ConsoleApp_Batch_11_30.oops.Abstraction
{
    class MyLoger : IEmailLogger
    {
        public void Log()
        {
            Console.WriteLine("My custom logic to log email");
        }
    }

    class MyEmailClient : EmailClient
    {
        public override void Log()
        {
            Console.WriteLine("Logged");
        }
    }
    internal class Startup
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();

            //IEmployeeRepository repository = new AzEmployeeRepository();

            //repository.Add(employee);

            EmailClient emailClient = new MyEmailClient();
            emailClient.SendMail();
        }
    }
}
