using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30.Arrays
{
    internal class JaggedArray
    {
        static void Main(string[] args)
        {
            int[] EvenNumbers = { 2, 4, 6, 8, 10 };
            int[] OddNumbers = { 1, 3, 5, 7, 9 ,11,13,15,17};

            int[][] Numbers = { EvenNumbers, OddNumbers };

            for (int i = 0; i < Numbers.Length; i++)
            {
                int[] Items = Numbers[i];

                for (int j = 0; j < Items.Length; j++)
                {
                    Console.Write(Items[j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
