using System;
using System.Collections;


namespace ConsoleApp_Batch_11_30.CollectionProgram
{
    internal class startup
    {
        static void Main(string[] args)
        {
            //object[] array = new object[2] { 1,"Kundan"};
            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add(2);
            //list.Add("abc");
            //list.Add(3);

            //list.RemoveRange(1,2);

            //foreach (var i in list) {
            //    Console.WriteLine(i);
            //}


            //if (password == pswd) {
            //    Console.WriteLine("both are equal");
            //}

            //string password = "Asmita";
            //string pswd = "asmita";
            //Console.WriteLine("Password 1 Hash : " + password.GetHashCode());
            //Console.WriteLine("Password 2 Hash : " + pswd.GetHashCode());

            Hashtable ht = new Hashtable();
            ht.Add(1, "ajay");
            ht.Add("tets", "ajay");

            foreach (var item in ht)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
