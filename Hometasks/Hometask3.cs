using System;

namespace Hometasks
{
    class TodaysDay
    {
        public static void splitData()
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
