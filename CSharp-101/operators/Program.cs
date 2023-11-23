using System;

namespace operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isHigher = 10 > 5;
            Console.WriteLine(isHigher);
            bool isLower = 10 < 5;
            Console.WriteLine(isLower);
            bool isEqual = 10 == 5;
            Console.WriteLine(isEqual);
            bool isNotEqual = 10 != 5;
            Console.WriteLine(isNotEqual);
            bool isHigherOrEqual = 10 >= 5;
            Console.WriteLine(isHigherOrEqual);
            bool isLowerOrEqual = 10 <= 5;
            Console.WriteLine(isLowerOrEqual);

            if (isHigher || isHigherOrEqual)
            {
                Console.WriteLine("is higher or is equal");
            }

            if (!isLower && !isLowerOrEqual)
            {
                Console.WriteLine("is lower and is lower or equal");
            }

            if (!isEqual)
            {
                Console.WriteLine("is not equal");
            }
        }
    }
}
