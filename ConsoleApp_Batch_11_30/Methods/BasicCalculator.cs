using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30.Methods
{
    internal class BasicCalculator
    {
        //Access_Specifiers [Return Type] Method Name ([input Parameters])
        //Method Body


        public bool SaveData(string EmployeeInfo, out string ErrorMessage)
        {
            //code to process data in data base;
            ErrorMessage = "There is error message";
            return false;
        }
        public void Increment(out int Value)
        {
            Value = 5;
           //Value = Value + 5;
        }
        public int Add(int Value1, int Value2)
        {
            return Value1 + Value2;
        }

        public bool IsPrime(int Value)
        {
            for (int i = 2; i < Value/2; i++)
            {
                if (Value % i == 0)
                    return false;
            }

            return true;
        }
    }
}

    
