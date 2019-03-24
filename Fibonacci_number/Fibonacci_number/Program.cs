using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_number
{
    class Program
    {
        private static Int32 a;
        private static Int32 n;

        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci number.");
            Console.Write("Enter position: ");
            Tryparse_a();
            Fibonacci_position(n);
            Console.ReadKey();
        }

        static void Tryparse_a()
        {
            do
            {
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
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
