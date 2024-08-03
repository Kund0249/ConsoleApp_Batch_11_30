using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30.CollectionProgram.Generic
{
    internal class GenericStartup
    {
      
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add("A");

            //HashSet<string> set = new HashSet<string>();
            //set.Add("A");
            //set.Add("B");
            //set.Add("A");
            //foreach (var item in set) {
            //    Console.WriteLine(item);
            //}


            //string value = "ABBCCDB"
            //A - 1
            //B - 3
            //C - 2
            //D - 1

            //Dictionary<int,string> map = new Dictionary<int,string>();
            //map.Add(1, "Ram");
            //map.Add(2, "Ram");

            //foreach (var item in map)
            //{
            //    Console.WriteLine(item.Key + "-" + item.Value);
            //}
            string value = "ABBACCDBA";
            Dictionary<char, int> map = new Dictionary<char, int>();

            for (int i = 0; i < value.Length; i++)
            {
                if (!map.ContainsKey(value[i]))
                    map.Add(value[i], 1);
                else
                    continue;

                for (int j = i+1; j < value.Length; j++)
                {
                    if (value[i] == value[j])
                        map[value[i]]++;
                }
            }

            foreach (var item in map)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
        }
    }
}
