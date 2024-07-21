using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30.oops
{

    class Loggin
    {
        public static Loggin logging { get; set; }
        public string LogingType { get; set; }

        private Loggin()
        {
            
        }

        public static Loggin GetInstance
        {
            get
            {
                if (logging == null)
                {
                    logging = new Loggin();
                }

                return logging;
            }
          
        }
        public void LogInfo()
        {
            Console.WriteLine("Loging Level : " + LogingType);
            //Log to database
            Console.WriteLine("Infomation Logged");
        }
    }

    class Studnet
    {
        //Declaration 
        public int RollNo;
        public string Name;
        public static int Count;

        //Default Constructor
        public Studnet()
        {
            Console.WriteLine("Default Constructor Invoked");
            RollNo = 0;
            Name = string.Empty;
            Count++;
        }

        public Studnet(int StudentId, string Name)
        {
            RollNo = StudentId;
            this.Name = Name;
            Count++;
        }

        public Studnet(Studnet studnet)
        {
            RollNo = studnet.RollNo;
            Name = studnet.Name;
            Count++;
        }

        static Studnet()
        {
            Console.WriteLine("Static Constructor Invoked");
            Count = 0;
        }
    }
    internal class Startup
    {
        int id;
        static void Main(string[] args)
        {
            //int N = 10;
            //string name = "john";
            //float salary = 10.5F;

            //Object - 1
            Studnet studnet = new Studnet();//Studnet(); - contructor
            Console.WriteLine("Roll No : {0}  Name : {1}", studnet.RollNo, studnet.Name);


            //Object - 2
            Studnet studnet1 = new Studnet(1, "A");
            Console.WriteLine("Roll No : {0}  Name : {1}", studnet1.RollNo, studnet1.Name);


            //Object - 3
            //Studnet studnet2 = studnet1;
            Studnet studnet2 = new Studnet(studnet1);
            Console.WriteLine("Roll No : {0}  Name : {1}", studnet2.RollNo, studnet2.Name);


            //studnet1.Name = "B";

            //Console.WriteLine("Roll No : {0}  Name : {1}", studnet2.RollNo, studnet2.Name);

            Console.WriteLine("Total object : " + Studnet.Count);

            Loggin loggin1 = Loggin.GetInstance;
            loggin1.LogingType = "Exception";


            Loggin loggin2 = Loggin.GetInstance;
            loggin2.LogInfo();

            Console.WriteLine("My Value");
        }
    }
}
