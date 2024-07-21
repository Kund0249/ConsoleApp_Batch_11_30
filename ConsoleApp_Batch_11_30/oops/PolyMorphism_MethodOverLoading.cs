using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30.oops
{

    class EmailService
    {
        public void Send(string toEmail,string subject, string body,string signature)
        {

        }

        public void Send(string toEmail, string subject, string body, string signature, byte[] file)
        {

        }
        public void Send(string toEmail,string CCEmails, string subject, string body, string signature)
        {

        }
    }
    class BasicCalculator
    {
        //Ref and Out keyword does not play any important role in method overloading
        public int Sum(int V1, int V2,ref int V3)
        {
            return V1 + V2;
        }

        //public int Sum(int V1, int V2, out int V3)
        //{
        //    V3 = 0;
        //    return V1 + V2;
        //}

        public float Sum(int V1, float V2)
        {
            return V1 + V2;
        }

        public float Sum(float V1, int V2)
        {
            return V1 + V2;
        }

        //Return type does not play any important role in method overloading
        //public bool Sum(float V1, int V2)
        //{

        //    return true;
        //}
    }
    internal class PolyMorphism_MethodOverLoading
    {
        static void Main(string[] args)
        {
            BasicCalculator cal = new BasicCalculator();
            cal.Sum(10.5F, 20);
        }
    }
}
