using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Student : Person
    {
        internal Student(string fname, string lname, int age) : base(fname, lname, age)
        {
        }

        public override void GoToTheDeanery()
        {
            Console.WriteLine("I am hungry for knowledge!!!");
        }
    }
}
