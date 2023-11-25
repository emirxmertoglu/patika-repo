using System;

namespace if_else_ternary_if
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int time = DateTime.Now.Hour;
            int time = 8;

            if (time >= 6 && time < 11)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time >= 11 && time < 18)
            {
                Console.WriteLine("Good afternoon.");
            }
            else if (time <= 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }


            string result =
                time >= 6 && time < 11 ? "Good morning."
                : time >= 11 && time < 18 ? "Good afternoon."
                : time <= 18 ? "Good day."
                : "Good evening.";
            Console.WriteLine(result);

        }
    }
}
