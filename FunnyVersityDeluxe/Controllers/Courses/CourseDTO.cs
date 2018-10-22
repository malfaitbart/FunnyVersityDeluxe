using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunnyVersityDeluxe.Controllers.Courses
{
    public class CourseDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double StudyPoints { get; set; }
        public string Category { get; set; }
        public int ProfessorID { get; set; }

    }
}
