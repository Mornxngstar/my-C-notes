using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Hello_world
{
    class DateTime_
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Today);

            Console.WriteLine(DateTime.Now);

            DateTime time = DateTime.Now;

            Console.WriteLine("{0}:{1}:{2}", time.Hour, time.Minute, time.Second);

            DateTime tomorrow = NextDay();
            Console.WriteLine(tomorrow);

            Console.WriteLine(DateTime.Today.DayOfWeek);

            Console.WriteLine(FirstDayOfYear(1999));

            Console.WriteLine(DateTime.DaysInMonth(2000,2));

            Console.WriteLine("Enter a date with the following format: YYYY/MM/DD\n");
            string input = Console.ReadLine();
            DateTime userDate;

            if (DateTime.TryParse(input, out userDate))
            {
                Console.WriteLine(time);
                TimeSpan wholeDays = time.Subtract(userDate);
                Console.WriteLine("{0} days have passed since the date you've entered.", wholeDays.Days);
            }

            Console.Read();
        }

        static DateTime NextDay()
        {
            return DateTime.Today.AddDays(300);
        }

        static DateTime FirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }

    }
}
