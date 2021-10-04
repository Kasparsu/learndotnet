using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace learndotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = new DateTime(1993, 03, 21, 14, 58, 33, 133);
            Console.WriteLine(time);
            Console.WriteLine(time.Date);
            Console.WriteLine(time.Hour);
            Console.WriteLine(time.Minute);
            Console.WriteLine(time.Second);
            Console.WriteLine(time.Millisecond);
            Console.WriteLine(time.Day);
            Console.WriteLine(time.Year);
            Console.WriteLine(time.Month);
            Console.WriteLine(time.DayOfWeek);
            Console.WriteLine(time.DayOfYear);
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            time = DateTime.Parse("2021-12-31");
            Console.WriteLine(time);
            time = time.AddDays(3);
            Console.WriteLine(time);
            Console.WriteLine(time.ToString("yyyy MMMM ddd"));
        }
    }
}
