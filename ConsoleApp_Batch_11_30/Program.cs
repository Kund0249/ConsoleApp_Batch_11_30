using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Number = System.Int32;
//using varchar = System.String;

namespace ConsoleApp_Batch_11_30
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello from program class");
            //Console.WriteLine("Hello");
            //Console.WriteLine("World");
            //Console.Write("Enter Name : ");
            //string StudenName = Console.ReadLine();
            //Console.WriteLine("Your name is " + StudenName);//string concatination
            // Console.WriteLine("your name is {0}",StudenName);
            //Console.WriteLine($"your name is {StudenName}");

            //Console.Write("Enter Name : ");
            //string StudenName = Console.ReadLine();

            //Console.Write("Enter Age : ");
            //int Age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter Gender : ");
            //string Gender = Console.ReadLine();

            //Console.WriteLine("Name : '" + StudenName + "' , Age : " + Age + " , Gender : " + Gender);
            //Console.WriteLine("Name : '{0}', Age : {1}, Gender : {2}",StudenName,Age,Gender);
            //Console.WriteLine($"Name : {StudenName}, Age : {Age}, Gender : {Gender}");

            string V1 = "10";
            String V2 = "20";

            Int32 N1 = int.Parse(V1);       //it can not convert null value;
            int N2 = Convert.ToInt32("10"); //it convert the null value into 0;

          
            //short
            //Int16 => 2 byte (16 bit)

            //int
            //Int32 => 4 byte

            //long
            //Int64 => 8 byte
            
            //What is the diff between int and Int32?
            //What is the diff between small string and capital string?


            Console.WriteLine("{0} + {1} = {2}",N1,N2,(N1+N2));
        }
    }
}
