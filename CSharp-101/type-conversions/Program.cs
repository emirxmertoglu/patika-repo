using System;

namespace type_conversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Implicit Conversions ****");
            float a; int b = 25; a = b;
            Console.WriteLine("a = {0}", a);

            Console.WriteLine("**** Explicit Conversions ****");
            int c = 25; float d; d = (float)c;
            Console.WriteLine("d = {0}", d);
            short x = 10; int y; y = x;
            Console.WriteLine("y = {0}", y);
            double m; float n = 10.5f; m = (double)n;
            Console.WriteLine("m = {0}", m);
        }
    }
}
