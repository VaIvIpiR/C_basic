using System;

namespace Homework
{
    class Deanery
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var deanstaff = new DeanStaff("Ivan", "Ivanov", 45);
            var student = new Student("Sasha", "Shpadkivskyi", 23);
            var teacher = new Teacher("Petro", "Solomak", 52);

        }
    }
}
