using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_number
{
    class Program
    {
        private static Int32 n;

        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci numbers.");
            Console.Write("Enter position: ");
            Tryparse_n();
            Int32 result = Fibonacci_position(n);
            Console.Write("Your fibonacci number is: ", result);
            Console.ReadKey();
        }

        static void Tryparse_n()
        {
            do
            {
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.Write("Invalid value. Please, try again: ");
                }
            } while (true);
        }
            

        static int Fibonacci_position(int n)
        {
            if (n == 0 || n == 1)
            return 1;
            else return Fibonacci_position(n - 1) + Fibonacci_position(n - 2);          
          
        }
    }
}
