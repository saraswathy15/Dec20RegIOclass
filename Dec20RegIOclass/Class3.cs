using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec20RegIOclass
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            string nameWeek = dt.DayOfWeek.ToString();
            DayOfWeek dt1 = dt.DayOfWeek;
            Console.WriteLine(dt1);
            Console.WriteLine(dt.Month);
            int yes = dt.Day - 1;
            Console.WriteLine(yes); //yester day 
            DateTime dt2 = new DateTime(2000, 4, 5);
            //difference between 2 dates 
            TimeSpan ts = dt - dt2;
            Console.WriteLine(ts.TotalDays);
            Console.WriteLine(ts.Days);
            Console.ReadLine();

        }
    }
}
