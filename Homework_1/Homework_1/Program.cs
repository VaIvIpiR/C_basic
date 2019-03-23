using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Program
    {
        // объявление всех переменных в теле класа (что бы не объявлять их в каждом методе отдельно)
        private static double x; //первое число
        private static double y; //второе число
        private static char operation; // опирация над числами
        private static double z; // результат

        // главный метод main который вызывает все остальные методы
        static void Main(string[] args)
        {

            Console.WriteLine("I am a small console calculator. I'm here to help you with simple calculations.");
            Condition(); //Вызов метода ввода исходных даных

            Console.ReadKey();

            /* Console.WriteLine("Enter x:");
             x = Console.ReadLine();
             Console.WriteLine("Enter y:");
             y = Console.ReadLine();
             Console.WriteLine("Enter operation:");
             operation = Console.ReadLine();*/

        }
        //Метод для ввода исходных даных
        public static void Condition()
        {

            Console.Write("Enter x: ");
            Verification();
            Console.Write("Enter y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operation: ");
            operation = Convert.ToChar(Console.ReadLine());
            Calculation(); //вывод метода вычисления результата
        }
        // Метод для вычисления результата
        public static void Calculation()
        {
            switch (operation)
            {
                case '+':
                    z = x + y;
                    Console.WriteLine($"Result: {z}");
                    break;

                case '-':
                    z = x - y;
                    Console.WriteLine($"Result: {z}");
                    break;

                case '*':
                    z = x * y;
                    Console.WriteLine($"Result: {z}");
                    break;

                case '/':
                        Verification();
                        z = x / y;
                        Console.WriteLine($"Result: {z}");
                        break;
                
                default:
                    Console.WriteLine("The operation is unknown. ");
                    break;

            }
        }
        // Метод проверки правильности введенных данных
        public static void Verification()
        {
            try
            {
                x = Convert.ToDouble(Console.ReadLine());

            }
            catch
            {
                Console.WriteLine("You entered invalid value. Please try again.");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
            finally
            {

            }
        }
            
    }
}
