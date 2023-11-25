using System;

namespace switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                    Console.WriteLine("You are on January month");
                    break;
                case 2:
                    Console.WriteLine("You are on February month");
                    break;
                case 3:
                    Console.WriteLine("You are on March month");
                    break;
                case 4:
                    Console.WriteLine("You are on April month");
                    break;
                case 5:
                    Console.WriteLine("You are on May month");
                    break;
                case 6:
                    Console.WriteLine("You are on June month");
                    break;
                case 7:
                    Console.WriteLine("You are on July month");
                    break;
                case 8:
                    Console.WriteLine("You are on August month");
                    break;
                case 9:
                    Console.WriteLine("You are on September month");
                    break;
                case 10:
                    Console.WriteLine("You are on October month");
                    break;
                case 11:
                    Console.WriteLine("You are on November month");
                    break;
                case 12:
                    Console.WriteLine("You are on December month");
                    break;
                default:
                    Console.WriteLine("Invalid month");
                    break;
            }

            switch(month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("You are on Winter");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("You are on Spring");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("You are on Summer");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("You are on Autumn");
                    break;
                default:
                    Console.WriteLine("Invalid month");
                    break;
            }
        }
    }
}
