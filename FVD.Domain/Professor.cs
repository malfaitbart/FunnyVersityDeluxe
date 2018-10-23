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

        private static int CountID;

        public Professor(string firstName, string lastName)
        {
            ID = CountID;
            FirstName = firstName;
            LastName = lastName;
            CountID++;
        }

        public Professor(int iD, string firstName, string lastName)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
