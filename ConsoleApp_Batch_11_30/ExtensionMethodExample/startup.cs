using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30.ExtensionMethodExample
{
    internal class startup
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>()
            {
                "B001","B002","B003","B004"
            };

            //string codes = "'B001','B002','B003','B004'";

            string codes = list.ToString('|');
            Console.WriteLine(codes);

            string Names = "A|B|C";

            var data = Names.ToList('|');
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
