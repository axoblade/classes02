using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjects
{
    class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
    }

    public class FullNames
    {
        public string fullnames(string firstName, string middleName, string lastName)
        {
            string fullName = firstName + " " + middleName + " " + lastName;

            return fullName;
        }
    }
}
