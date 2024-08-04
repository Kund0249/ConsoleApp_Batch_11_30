using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30.CollectionProgram.Generic
{
    public sealed class TokenGenerator
    {
        public static Random GetTokenInstance;
        private TokenGenerator()
        {
            
        }

        public static Random Instance
        {
            get
            {
                if (GetTokenInstance == null)
                    GetTokenInstance = new Random();

                return GetTokenInstance;
            }
        }
    }
    class OrderToken
    {
        public string AssignTo { get; set; }
        public int TokenNumber { get;}


        public OrderToken()
        {
          
            TokenNumber = TokenGenerator.Instance.Next();
        }
    }
    internal class QueueExample
    {
        static void Main(string[] args)
        {
            Queue<OrderToken> orderTokens = new Queue<OrderToken>();
            orderTokens.Enqueue(new OrderToken { AssignTo = "A" });
            orderTokens.Enqueue(new OrderToken { AssignTo = "B" });
            orderTokens.Enqueue(new OrderToken { AssignTo = "C" });
            orderTokens.Enqueue(new OrderToken { AssignTo = "D" });
            orderTokens.Enqueue(new OrderToken { AssignTo = "E" });

            while (true)
            {
                foreach (var item in orderTokens)
                {
                    Console.WriteLine($"Token : {item.TokenNumber}, Assign To : {item.AssignTo}");
                }

                Console.WriteLine("-------------------------------------");

                Console.Write("Show your Toke : ");
                int TokenNumber = Convert.ToInt32(Console.ReadLine());

                if(orderTokens.Peek().TokenNumber == TokenNumber)
                {   
                    orderTokens.Dequeue();
                    Console.WriteLine("Thanks For Service.");
                }
                else
                {
                    Console.WriteLine("Your service is not redy to serve.");
                }
                Console.WriteLine("-------------------------------------");
            }
           
        }
    }
}
