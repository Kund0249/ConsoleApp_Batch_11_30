using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30
{
    //Types of Variables
    /*
     1) Local Variable
     2) Instance Variable
     3) Static Variable
     4) Constant Variable
     5) ReadOnly Variable
     
     */
    class TypesOfVariables
    {
        //Instance Variable
        int Age;

        //Static Variable
        static string CollegeName = "S. K Somaiya";


        const float PI = 3.14F;
        readonly int readonlyvalue;

        public TypesOfVariables()
        {
            //logic
            readonlyvalue = 10;
        }

        int Value1 = 10;


        //These N1 and N2 are know as Local Variables
        public void Sum(int N1,int N2)
        {
           
            Console.WriteLine("Sum : " + (N1+N2));
        }
        static void Main(string[] args)
        {
            
            TypesOfVariables object1 = new TypesOfVariables();
            object1.Age = 10;
            object1.Value1 = 30;

           
            Console.WriteLine(PI);

            TypesOfVariables object2 = new TypesOfVariables();
            object2.Age = 20;


           // Console.WriteLine("College : " + TypesOfVariables.CollegeName);


        }
    }
}
