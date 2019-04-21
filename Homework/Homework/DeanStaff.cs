using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class DeanStaff : Person
    {
        internal DeanStaff(string fname, string lname, int age) : base(fname, lname, age)
        {
        }

        public override void GoToTheDeanery()
        {
            Console.WriteLine("I am going to the work :(");
        }
    }
}
