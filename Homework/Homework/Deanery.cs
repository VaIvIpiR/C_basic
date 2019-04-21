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

            Console.Write("DeanStaff: ");
            deanstaff.GoToTheDeanery();
            Console.Write("Student: ");
            student.GoToTheDeanery();
            Console.Write("Teacher: ");
            teacher.GoToTheDeanery();

            Console.ReadKey();

        }
    }
}
