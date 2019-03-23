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
            Calculation(); //вывод метода вычисления результата

            Console.ReadKey();


        }
        //Метод для ввода исходных даных
        public static void Condition()
        {

            Console.Write("Enter x: ");
            Verification_x();
            Console.Write("Enter y: ");
            Verification_y();
            Console.Write("Enter operation: ");
            Verification_operation();
        }
        // Метод для вычисления результата
        public static void Calculation()
        {
            switch (operation)
            {
                case '+':
                    z = x + y;
                    Console.Write($"Result: {z}");
                    break;

                case '-':
                    z = x - y;
                    Console.Write($"Result: {z}");
                    break;

                case '*':
                    z = x * y;
                    Console.Write($"Result: {z}");
                    break;

                case '/':
                        Division_by_zero();
                        break;
                
                default:
                    Console.Write("The operation is unknown.");
                    break;

            }
        }
        // Метод проверки правильности введеного "х"
        public static void Verification_x()
        {
            do
            {
                try
                {
                    x = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.Write("Invalid value. Please, try again: ");
                }
            } while (true);

        }

        // Метод проверки правильности введеного "у"
        public static void Verification_y()
        {
            do
            {
                try
                {
                    y = Convert.ToDouble(Console.ReadLine());
                    break;

                }
                catch (FormatException)
                {
                    Console.Write("Invalid value. Please, try again: ");
                }
            } while (true);

        }

        // Метод проверки правильности введения операции 
        public static void Verification_operation()
        {
            do
            {
                try
                {
                    operation = Convert.ToChar(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.Write("Invalid value. Please, try again: ");
                }
            } while (true);

        }

        public static void Division_by_zero()
        {
            try
            {
                z = x / y;
            }
            catch
            {
                Console.WriteLine("You try to divide by zero!");
            }
            finally
            {
                z = x / y;
                Console.Write($"Result: {z}");
            }

        }

    }
}
