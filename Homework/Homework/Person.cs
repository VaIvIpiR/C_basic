using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
   internal class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }

        private DateTime dateOfBirth;
        public int Age { get; private set; }

        public int GetAge()
        {
            System.DateTime dateNow = DateTime.Now;
            return (dateNow.Year - dateOfBirth.Year);
        }

        public Person(string fname, string lname, int age)
        {
            FirstName = fname;
            LastName = lname;
            Age = age;

        }

    }
}

