using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30.Arrays
{
    internal class ThreeLargestNumberFromArray
    {
        static void Main(string[] args)
        {
            int[] Numbers = { -3,-5,-5,-1,-2,-8,-9 };

            int First = int.MinValue;
            int Second = int.MinValue;
            int Third = int.MinValue;

            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] > First)
                {
                    Third = Second;
                    Second = First;
                    First = Numbers[i];

                }
                else if (Numbers[i] > Second && Numbers[i] != First)
                {
                    Third = Second;
                    Second = Numbers[i];

                }
                else if (Numbers[i] > Third && Numbers[i] != Second)
                {
                    Third = Numbers[i];
                }
            }

            Console.WriteLine("First : " + First);
            Console.WriteLine("Second : " + Second);
            Console.WriteLine("Third : " + Third);
        }
    }
}
