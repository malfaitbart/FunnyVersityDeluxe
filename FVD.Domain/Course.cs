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
        public int ProfessorID { get;  set; }

        private static int CountID;

        public Course(string name, double studyPoints, string category, int professorID)
        {
            ID = CountID;
            Name = name;
            StudyPoints = studyPoints;
            Category = category;
            ProfessorID = professorID;
            CountID++;
        }

        public Course(int iD, string name, double studyPoints, string category, int professorID)
        {
            ID = iD;
            Name = name;
            StudyPoints = studyPoints;
            Category = category;
            ProfessorID = professorID;
        }
    }
}
