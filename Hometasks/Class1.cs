using System;

namespace Hometasks
{
    class Execution
    {
        static void Main(string[] args)
        {
            //For Hometask1
            OverloadedFunctions example = new OverloadedFunctions();
            example.Func("string");
            example.Func(-1);

            //For Hometask2
            MessageForEachDay.writeMessage();

            //For Hometask3
            TodaysDay.splitData();
            Console.ReadKey();
        }
    }
}
