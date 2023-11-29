using System;

namespace method_overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20, c = 30;
            Console.WriteLine(Sum(a, b));
            Console.WriteLine(Sum(a, b, c));
            Console.WriteLine(Sum(a, b, out int sum));
            Console.WriteLine(sum);
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        static int Sum(int a, int b, out int sum)
        {
            sum = a + b;
            return sum;
        }
    }
}
