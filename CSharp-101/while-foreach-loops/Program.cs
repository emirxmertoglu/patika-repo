using System;

namespace while_foreach_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** While Loop ****");
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= number)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("Finished!");

            Console.WriteLine("**** Do While Loop ****");
            int j = 1;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j <= 10);

            Console.WriteLine("**** Foreach Loop ****");
            string[] cars = { "BMW", "Ford", "Mazda", "Toyota" };
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            int[] numbers = { 4, 5, 3, 2, 1, 7, 8, 5, 1, 4, 2, 4, 5 };
            int sum = 0;
            foreach (int x in numbers)
            {
                sum += x;
            }
            Console.WriteLine("Sum of numbers array is {0}", sum);
            Console.WriteLine("Average of numbers array is {0}", sum / numbers.Length);

            Console.WriteLine("Finished!");
        }
    }
}
