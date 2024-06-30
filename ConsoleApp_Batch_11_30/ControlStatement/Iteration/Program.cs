using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30.ControlStatement.Iteration
{
    class Program
    {
        /*
           2*1 = 1
           2*2 = 4
         */
        static void Main(string[] args)
        {

            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("Hello World");
            //}

            for (int i = 1; i < 11; i++)
            {
                for (int j = 2; j < 11; j++)
                {
                    Console.Write(i * j + "\t"); //2 3 4 .. 10
                                                 //4 6 8 .. 20
                }
                Console.WriteLine();
            }

           
        }
    }
}
