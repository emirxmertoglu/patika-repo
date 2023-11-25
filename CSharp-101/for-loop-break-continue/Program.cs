using System;

namespace for_loop_break_continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number, and I will tell you all the numbers that are divisible by 3 between 1 and your number.");
            Console.WriteLine("If you enter 0 or a negative number, the program will end.");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("The program will now count to 100, but will stop at 50, and it wont show you numbers who divided by 11");
            for (int i = 1; i < 100; i++)
            {
                if (i % 11 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
                if (i == 50)
                {
                    break;
                }
            }
        }
    }
}
