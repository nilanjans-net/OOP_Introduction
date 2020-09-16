using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Introduction
{
    class MyPerson
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string getOwnerName() { 
            return firstName + " " + lastName;
        }

        public MyPerson(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
