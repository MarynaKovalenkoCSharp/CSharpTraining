using System;

namespace Hometask3
{
    class TodaysDay
    {
        static void Main(string[] args)
        {
            DateTime myDate = new DateTime(2015, 12, 14);
            var dayParts = myDate.ToString("D").Split(',');
            //foreach (var Part in dayParts) {
            //Console.WriteLine(Part.Trim());
            for (int i = 0; i < dayParts.Length; i++ )
            {
                var part = dayParts[i];
                Console.WriteLine(part.Trim());
            }
            
        }
    }
}
