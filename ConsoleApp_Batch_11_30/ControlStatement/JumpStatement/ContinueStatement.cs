using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30.ControlStatement.JumpStatement
{
    internal class ContinueStatement
    {
        static void Main(string[] args)
        {

            int N = 15;
            bool IsPrime = true;

            Console.WriteLine("Program Start");
            for (int i = 2; i < N; i++)
            {
                Thread.Sleep(1000);
                if (N % i == 0)
                {  
                    IsPrime = false;
                    break;
                }
            }

            if (IsPrime) {
                Console.WriteLine("{0} is a prime number",N);
            }
            else
            {
                Console.WriteLine("{0} is not a prime number", N);
            }
            //for (int i = 1; i <= 20; i++) 
            //{
            //    //code

            //    if (i % 5 == 0)
            //        continue;

            //    //Calculate bucketing

            //    //Calculate Productive hours

            //    //Process Data into System
            //    //code
            //    Console.WriteLine(i);
            //}
        }
    }
}
