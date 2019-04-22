using System;

namespace Homework
{
    class Deanery
    {
        static void Main(string[] args)
        {

            var deanstaff = new DeanStaff("Ivan", "Ivanov", 45);
            var student = new Student("Sasha", "Shpadkivskyi", 23);
            var teacher = new Teacher("Petro", "Solomak", 52);
            var scanner = new Scanner();
            var coffemachine = new СoffeeMachine();

            Console.Write("Dean Staff: ");
            deanstaff.GoToTheDeanery();
            Console.Write("Student: ");
            student.GoToTheDeanery();
            Console.Write("Teacher: ");
            teacher.GoToTheDeanery();
            Console.Write("Scanner: ");
            scanner.DoSomething();
            Console.Write("Coffee Machine: ");
            coffemachine.DoSomething();

            Console.ReadKey();

        }
    }
}
