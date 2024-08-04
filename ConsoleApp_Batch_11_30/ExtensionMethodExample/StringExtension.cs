using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30.ExtensionMethodExample
{
  
    public static class ListExtension
    {
        public static string ToString(this List<string> list, char Deliminator)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var item in list)
            {
                builder.Append($"'{item}'{Deliminator}");
            }
            builder = builder.Remove(builder.ToString().LastIndexOf(Deliminator), 1);
            //Console.WriteLine(list);
            return builder.ToString();
        }
    }
    internal static class StringExtension
    {
        public static List<string> ToList(this string Value,char Deliminator)
        {
            string[] values = Value.Split(Deliminator);
            return new List<string>(values);
        }
    }
}
