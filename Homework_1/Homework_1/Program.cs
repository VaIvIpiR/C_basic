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
        private static double z; // конечный ответ

        // главный метод main который вызывает все остальные методы
        static void Main(string[] args)
        {


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

            Console.WriteLine("Enter x:");
            Verification();
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter operation:");
            Verification();
            operation = Convert.ToChar(Console.ReadLine());
            Calculation();
        }
        // Метод для вычисления конечного ответа
        public static void Calculation()
        {
            switch (operation)
            {
                case '+':
                    z = x + y;
                    Console.WriteLine(z);
                    break;

                case '-':
                    z = x - y;
                    Console.WriteLine(z);
                    break;

                case '*':
                    z = x * y;
                    Console.WriteLine(z);
                    break;

                case '/':
                    if (y != 0)
                    {
                        z = x / y;
                        Console.WriteLine(z);
                        break;
                    }
                    else
                        Console.WriteLine("The denominator can not be equel to zero");
                default:
                    Console.WriteLine("The operation is unknown. ");
                    break;

            }
        }
        // Метод проверки правильности введенных данных
        public static void Verification()
        {
            if (x )
            {
                Console.WriteLine("Converted '{0}' to {1}.", value, number);
            }
            else
            {
                Console.WriteLine("Attempted conversion of '{0}' failed.",
                                   value ?? "<null>");

            }
    }
}
