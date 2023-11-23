using System;

namespace error_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = Int32.Parse(Console.ReadLine());
                int b = Int32.Parse(Console.ReadLine());
                int c = a + b;
                Console.WriteLine("Sum = {0}", c);
            }
            catch (ArgumentNullException er)
            {
                Console.WriteLine(er.Message);
            }
            catch (FormatException er)
            {
                Console.WriteLine(er.Message);
            }
            catch (OverflowException er)
            {
                Console.WriteLine(er.Message);
            }
            catch (Exception er)
            {
                Console.WriteLine(er.Message);
            }
            finally
            {
                Console.WriteLine("Process Completed");
            }
        }
    }
}
