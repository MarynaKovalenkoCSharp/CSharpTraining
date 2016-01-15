using System;

namespace Hometasks
{
    class OverloadedFunctions
    {
        public string resultingWord;
        public string resultingValue;

        public string Func(string myWord)
        {
            string resultingWord = "";
            for (int i = 0; i < myWord.Length; i++)
            {
                resultingWord += myWord[i] + " ";
            }
            Console.WriteLine(resultingWord);
            return resultingWord;
        }

        public string Func(int myValue)
        {

            if (myValue >= 5)
            {
                Condition.TooBig.ToString();
                resultingValue = Enum.GetName(typeof(Condition), 0);
            }
            else
            {
                resultingValue = Enum.GetName(typeof(Condition), 1);
            }
            Console.WriteLine(resultingValue);
            return resultingValue;
        }

    }

    enum Condition
    {
        TooBig,
        Toosmall
    };
}