using System;

namespace variables_and_data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // I'm not a new developer, so I just want to try some interesting things

            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            string todayFull = DateTime.Now.ToString("F");
            Console.WriteLine(todayFull);
            string todayShort = DateTime.Now.ToString("dd MMM yyyy ddd");
            Console.WriteLine(todayShort);
            string todayShorter = DateTime.Now.ToString("d");
            Console.WriteLine(todayShorter);
        }
    }
}
