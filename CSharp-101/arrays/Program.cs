using System;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5];
            //numbers[0] = 4;
            //numbers[1] = 8;

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 4, 8, 15, 16, 23, 42 };

            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter number: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            Console.WriteLine("Summary of the numbers array is: {0}", sum / length);
        }
    }
}
