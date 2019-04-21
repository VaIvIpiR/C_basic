using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }
        public string Email { get; private set; }

        private DateTime dateOfBirth;
        public string Age { get; private set; }

        public string GetAge()
        {
            System.DateTime dateNow = DateTime.Now;
            return (dateNow.Year - dateOfBirth.Year).ToString();
        }

    }
}

