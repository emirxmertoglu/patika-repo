using System.Collections;

namespace collections_question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList primeNumber = new ArrayList();
            ArrayList nonPrimeNumber = new ArrayList();

            for (int i = 0; i < 20; i++)
            {
                int number = 0;
                do
                {
                    Console.WriteLine($"Enter {i + 1}. number: ");
                    var input = Console.ReadLine();
                    if (int.TryParse(input, out number))
                    {
                        if (number > 0)
                        {
                            if (IsPrime(number))
                            {
                                primeNumber.Add(number);
                            }
                            else
                            {
                                nonPrimeNumber.Add(number);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please enter a positive number.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }

                } while (number == 0);
            }

            // Prime Numbers

            primeNumber.Sort();
            primeNumber.Reverse();

            Console.WriteLine("Prime Numbers: ");
            foreach (var item in primeNumber)
            {
                Console.Write("{0}, ", item);
            }

            // Non-Prime Numbers

            nonPrimeNumber.Sort();
            nonPrimeNumber.Reverse();
            Console.WriteLine("Non-Prime Numbers: ");
            foreach (var item in nonPrimeNumber)
            {
                Console.Write("{0}, ", item);
            }

            // Prime Numbers Count & Average
            Console.WriteLine($"Prime Numbers Count = {primeNumber.Count}");
            int average = primeNumber.ToArray().Aggregate(0, (sum, x) => sum + int.Parse(x), x => x / primeNumber.Count);
            Console.WriteLine($"Prime Numbers Average = {average}");



        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
