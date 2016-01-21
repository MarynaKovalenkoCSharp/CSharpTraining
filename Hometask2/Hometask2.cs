using System;

namespace Hometask2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            DayOfWeek today = DateTime.Today.DayOfWeek;
            switch (today) {
                case DayOfWeek.Monday:
                    Console.WriteLine("Понедельник - день тяжелый");
                        break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Вторник тоже день нелегкий");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Ура, уже среда! Прошла почти половина рабочей недели");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Сегодня четверг!");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Наконец-то пятница!");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Поздравляем! Сегодня суббота!");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("Сегодня воскресенье, завтра на работу");
                    break;

            }
        }
    }
}
