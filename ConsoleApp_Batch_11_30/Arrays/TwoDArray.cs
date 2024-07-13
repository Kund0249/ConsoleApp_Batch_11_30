using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30.Arrays
{
    internal class TwoDArray
    {
        //int[] ar = new int[2] {10,20 };
        static void Main(string[] args)
        {
            int[,] MatrixA = new int[2, 2]
               {
                 {10,20},
                 {30,40}
               };

            for (int r = 0; r < 2; r++)
            {
                for (int c = 0; c < 2; c++) {
                    Console.Write(MatrixA[r,c] + "\t");
                }
                Console.WriteLine();
            }
        }


    }
}
