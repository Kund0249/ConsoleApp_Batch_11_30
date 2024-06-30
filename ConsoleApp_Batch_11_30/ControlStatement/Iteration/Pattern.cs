using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30.ControlStatement.Iteration
{
    class Pattern
    {

        /*
           *
          * *
         *   *
        *******
        
         */
        static void Main(string[] args)
        {
            //Console.WriteLine("   *");
            //Console.WriteLine("  * *");
            //Console.WriteLine(" *   *");
            //Console.WriteLine("*******");

            int S = 3;
            int P = 1;
            for (int i = 1; i < 5; i++)
            {
                for (int j = 0; j < S; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= P; j++)
                {
                    if (i == 4 || j == 1 || j == P)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                    //if (j % 2 == 0)
                    //    Console.Write(" ");
                    //else 
                    //    Console.Write("*");
                }
                S--;
                P += 2;
                Console.WriteLine();
            }
        }
    }
}
