using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_number
{
    class Program
    {
        private static Int32 n; //Номер позиции 

        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci numbers.");
            Data();
            Solution();
            Console.ReadKey();
        }

        //Метод для ввода исходных даных
        public static void Data()
        {
            Console.Write("Enter position: ");
            Tryparse_n(); //Вызов метода проверки "n"
        }

        public static void Solution()
        {
            long result = Fibonacci_position(n); // Присвоения решения метода вычисления числа фибоначчи
            Console.Write($"Your fibonacci number is: {result}");
        }

        //Метод проверки "n"
        public static void Tryparse_n()
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
            
        //Метод вычисления числа фибоначчи
        public static int Fibonacci_position(int n)
        {
            if (n == 0 || n == 1)
                return n;
            else
            {
                return Fibonacci_position(n - 1) + Fibonacci_position(n - 2);
            }
        }
    }
}
