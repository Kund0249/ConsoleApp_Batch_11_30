using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30.ExceptionHandling
{
    internal class Startup
    {
        static void Main(string[] args)
        {
            //input => AAABBBCCCAABBCC
            //output => A3B3C3A2B2C2

            //step 1 => Empty variable //A3B
            //step 2 => count = 1 //3

            //loop
            //
            try
            {
                string inputes = "AAABBBCCCAABBCC";
                string outputs = string.Empty;
                int count = 1;

                for (int i = 1; i < inputes.Length; i++)
                {
                    if (inputes[i-1] != inputes[i])
                    {
                        outputs += (inputes[i] + count.ToString());
                        count = 1;
                    }
                    else
                    {
                        count++;
                    }
                }
                Console.WriteLine(outputs);
                //Console.WriteLine("Hi"); //syntax error => Compile Time Error


                Console.Write("Eneter N1 : ");
                int V1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Eneter N1 : ");
                int V2 = Convert.ToInt32(Console.ReadLine());
                if (V2 == 0)
                    throw new Exception("A number can't be devided by 0");
                //Exception ab = new Exception(){Message = ""};
                //ab.Message = ""
                int result = V1 / V2; //Logical Error => Run Time

                //n line code

                //Console.WriteLine("Hello");
            }
            catch (FormatException ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Incorrect input, kindly enter a positive numeric value!");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("kindly enter a positive numeric value between 0  to {0}!", int.MaxValue);
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                //log the exception;
                //notify the owner of application/team
                Console.WriteLine("Currently system is not able to process this request, try after some time!");
            }
        }
    }
}
