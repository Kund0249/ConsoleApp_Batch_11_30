using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30
{
    class TypeCasting
    {
        static void Main(string[] args)
        {
            int N1 = 10000;
            byte N2 = (byte)N1;//data may be loss

            Console.WriteLine(N2);

            byte V1 = 10;
            int V2 = V1; //Implicit Conversion
        }
    }
}
