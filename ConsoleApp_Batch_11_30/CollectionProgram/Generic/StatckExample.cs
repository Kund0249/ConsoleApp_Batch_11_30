using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30.CollectionProgram.Generic
{
    internal class StatckExample
    {
        static void Main(string[] args)
        {
            string formulla = "[[[{}]]";
            bool IsBalanced = false;

            Stack<char> openbrackets = new Stack<char>();// {'['}

            foreach (char c in formulla)
            {
                if(c == '(' || c == '{' || c == '[')
                    openbrackets.Push(c);
                else
                {
                    if (c == ')' || c == '}' || c == ']')
                    {
                        if(openbrackets.Count == 0)
                        {
                            IsBalanced = false;
                            break;
                        }

                        char closedbracket = c;
                        char openbracket = openbrackets.Pop();

                        if ((openbracket == '(' && closedbracket == ')')
                            || (openbracket == '{' && closedbracket == '}')
                            || (openbracket == '[' && closedbracket == ']'))
                        {
                            IsBalanced = true;
                        }
                        else
                        {
                            IsBalanced = false;
                        }
                    }
                   
                }
            }

            if (IsBalanced) { Console.WriteLine("Balanced"); }
            else { Console.WriteLine("UnBalanced"); }
        }
    }
}
