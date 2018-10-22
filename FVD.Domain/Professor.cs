using System;
using System.Collections.Generic;
using System.Text;

namespace FVD.Domain
{
    public class Professor
    {
        public int ID { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Professor(int iD, string firstName, string lastName)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
