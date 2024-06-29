using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30.ControlStatement.Selection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter Number : ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //if(n > 0 )
            // Console.WriteLine("Here is your entered +ve value : " + n);
            //else if(n < 0)
            // Console.WriteLine("Here is your entered -ve value : " + n);
            //else if (n < 0)
            //    Console.WriteLine("Here is your entered -ve value : " + n);
            //else 
            //    Console.WriteLine("{0} is neither +ve nor -ve",n);


            Console.Write("Enter N1 : ");
            int N1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter N1 : ");
            int N2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Operator [+,-,/,*] : ");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine();

            //if(op == '+')
            //    Console.WriteLine($"Result = {N1+N2}");
            //else if(op == '-')
            //    Console.WriteLine($"Result = {N1 - N2}");
            //else if (op == '*')
            //    Console.WriteLine($"Result = {N1 * N2}");
            //else if (op == '/')
            //    Console.WriteLine($"Result = {N1 / N2}");
            //else
            //    Console.WriteLine("OOPS! Incorrected operator selected.");

            switch (op)
            {
                case '+': Console.WriteLine($"Result = {N1 + N2}");
                    break;
                case '-':
                    Console.WriteLine($"Result = {N1 - N2}");
                    break;
                case '*':
                    Console.WriteLine($"Result = {N1 * N2}");
                    break;
                case '/':
                    Console.WriteLine($"Result = {N1 / N2}");
                    break;
                default:
                    Console.WriteLine("OOPS! Incorrected operator selected.");
                    break;
            }
        }
    }
}
