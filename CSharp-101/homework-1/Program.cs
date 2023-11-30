using System;

namespace homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }

        static void Task1()
        {
            Console.WriteLine("**** Task 1 ****");
            Console.Write("Enter size number (n): ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter {0}. positive integer: ", i + 1);
                int number = int.Parse(Console.ReadLine());
                arr[i] = number;
            }

            Console.WriteLine("Even numbers are: ");
            foreach (int number in arr)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }
        }

        static void Task2()
        {
            Console.WriteLine("**** Task 2 ****");
            Console.Write("Enter size number (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter target positive integer: ");
            int m = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter {0}. positive integer: ", i + 1);
                int number = int.Parse(Console.ReadLine());
                arr[i] = number;
            }

            Console.WriteLine("Numbers that are equal or whole divisible number to the target number are: ");
            foreach (int number in arr)
            {
                if (number % m == 0 || number == m)
                {
                    Console.WriteLine(number);
                }
            }
        }
        static void Task3()
        {
            Console.WriteLine("**** Task 3 ****");
            Console.Write("Enter size number (n): ");
            int n = int.Parse(Console.ReadLine());

            string[] arr = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter {0}. word: ", i + 1);
                string word = Console.ReadLine();
                arr[i] = word;
            }
            Array.Reverse(arr);
            Console.WriteLine("Reversed words are: ");
            foreach (string word in arr)
            {
                Console.WriteLine(word);
            }
        }

        static void Task4()
        {
            Console.WriteLine("**** Task 4 ****");
            Console.Write("Enter a sentence: ");
            string str = Console.ReadLine();
            string[] arr = str.Split(' ');
            Console.WriteLine("Total words are: {0}", arr.Length);
            Console.WriteLine("Total characters are: {0}", str.Length);
        }
    }
}
