using System;

namespace Hometask
{
    class OverloadedFunctions
    {
        public void Func(string Arg)
        {
            string result = "";
            foreach (char c in Arg)
            {
                string withSpace = c + " ";
                result = result + withSpace;

            }
            Console.WriteLine(result);
            return result;
        }

        public void Func(int val)
        {
            string res;

            if (val >= 5)
            {
                res = Enum.GetName(typeof(Condition), 0);
            }
            else
            {
                res = Enum.GetName(typeof(Condition), 1);
            }
            Console.WriteLine(res);
        }

    }

    enum Condition
    {
        TooBig,
        Toosmall
    };

    class Program
    {
        static void Main(string[] args)
        {
            OverloadedFunctions example = new OverloadedFunctions();
            example.Func("string");
            example.Func(-1);
        }
    }
}