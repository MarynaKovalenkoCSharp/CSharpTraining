using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "I need to find substring here";
            string mySubstr = "ned";
            bool myBool = true;
            for (int i = 0; i < myString.Length; i++)
            {
                if (myString[i] == mySubstr[0])
                {
                    for (int n = 0; n < mySubstr.Length; n++)
                    {
                        if (myString[i] == mySubstr[n] && mySubstr.Length <= myString.Length - i)
                        {
                            i++;
                            myBool = myBool && true;
                        }
                        else
                        {
                            myBool = myBool && false;
                        }
                    }
                    if (myBool == true)
                    {
                        Console.WriteLine("Substring found!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Substring not found");
                        break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}