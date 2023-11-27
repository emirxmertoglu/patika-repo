using System;

namespace array_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 44, 12, 54, 23, 11, 5, 222, 52, 76, 66, 1 };
            Console.WriteLine("**** Unsorted Array ****");
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("**** Sorted Array ****");
            Array.Sort(arr);
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("**** Cleared Array ****");
            Array.Clear(arr, 3, 4);
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("**** Reversed Array ****");
            Array.Reverse(arr);
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("**** Array IndexOf ****");
            Console.WriteLine(Array.IndexOf(arr, 54));

            Console.WriteLine("**** Array Resize ****");
            Array.Resize<int>(ref arr, 20);
            arr[19] = 100;
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
