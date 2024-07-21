using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp_Batch_11_30.oops
{
    class EmailService2
    {
        public void Send(string toEmail, string subject, string body, string signature)
        {
            //Code to send email
            Log();

        }

        public void Send(string toEmail, string subject, string body, string signature, byte[] file)
        {
            //Code to send email
            Log();
        }
        public void Send(string toEmail, string CCEmails, string subject, string body, string signature)
        {
            //Code to send email
            Log();
        }

        public virtual void Log()
        {
            Console.WriteLine("Email is logged");
        }
    }

    class CustomeEmailService : EmailService2
    {

        public override void Log()
        {
            string FilePathe = @"C:\Users\lenovo\Desktop\EmailLog.txt";
            StreamWriter writer = new StreamWriter(FilePathe, true);
            writer.WriteLine("My email is logged");
            writer.WriteLine("-----------------------------------");
            writer.Close();
        }
    }

    internal class Polymorphism_MethodOverridin
    {
        static void Main(string[] args)
        {
            //EmailService2 emailService = new EmailService2();
            //CustomeEmailService emailService = new CustomeEmailService();

            //emailService.Send("test@gmail.com", "Test Subject", "Test Message", "Test Signature");

            //int N1 = 10;
            //int N2 = 10;

            //bool isEqual = N1.Equals(N2);

            //Console.WriteLine(isEqual);

            Employee e1 = new Employee() { Name = "Test" };
            Employee e2 = new Employee() { Name = "Test2" };

            bool isEqual = e1.Equals(1);

            Console.WriteLine(isEqual);
        }
    }
}
