using System;
using System.Collections.Generic;
using System.Text;

namespace FVD.Domain
{
    public class Course
    {
        public int ID { get;  set; }
        public string Name { get;  set; }
        public double StudyPoints { get;  set; }
        public string Category { get;  set; }
        public Professor Professor { get;  set; }

    }
}
