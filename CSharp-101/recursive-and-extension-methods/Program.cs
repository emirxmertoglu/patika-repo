using System;
using System.Linq;

namespace recursive_and_extension_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Recursive Method ****");
            Console.Write("Enter a number to calculate its factorial: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factorial of {0} is {1}", number, Factorial(number));

            Console.WriteLine("**** Extension Method ****");
            Console.WriteLine(number.Factorial());

            string str = "Hello World";
            Console.WriteLine(str.Reverse());
        }

        static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }

    public static class ExtensionMethods
    {
        public static int Factorial(this int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        public static string Reverse(this string s)
        {
            char[] tempArr = s.ToCharArray();
            Array.Reverse(tempArr);
            return new string(tempArr);

        }
    }
}
