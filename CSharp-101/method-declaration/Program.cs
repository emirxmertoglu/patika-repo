using System;

namespace method_declaration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Console.WriteLine("**** Sum Method With No Ref ****");
            int result = Sum(a, b);
            Console.WriteLine(result);

            Console.WriteLine("**** External Print Method From Another Class ****");
            ExternalMethods externalMethods = new ExternalMethods();
            externalMethods.Print(Convert.ToString(result));

            Console.WriteLine("**** Sum Method With Ref ****");
            int result2 = externalMethods.Sum(ref a, ref b);
            externalMethods.Print(Convert.ToString(result2));
            externalMethods.Print(Convert.ToString(a));
            externalMethods.Print(Convert.ToString(b));
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }
    }

    class ExternalMethods
    {
        public void Print(string param)
        {
            Console.WriteLine(param);
        }

        public int Sum(ref int a, ref int b)
        {
            a++;
            b++;
            return a + b;
        }
    }
}
