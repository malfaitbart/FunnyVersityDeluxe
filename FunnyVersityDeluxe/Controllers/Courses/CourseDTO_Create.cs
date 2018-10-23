using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunnyVersityDeluxe.API.Controllers.Courses
{
    public class CourseDTO_Create
    {
        public string Name { get; set; }
        public double StudyPoints { get; set; }
        public string Category { get; set; }
        public int ProfessorID { get; set; }
    }
}
