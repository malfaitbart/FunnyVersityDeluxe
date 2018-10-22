using FVD.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunnyVersityDeluxe.Controllers.Courses
{
    public class CourseMapper
    {
        public CourseDTO ToDTO(Course course)
        {
            var courseDTO = new CourseDTO();
            courseDTO.ID = course.ID;
            courseDTO.Name = course.Name;
            courseDTO.StudyPoints = course.StudyPoints;
            courseDTO.Category = course.Category;
            courseDTO.ProfessorID = course.ProfessorID;

            return courseDTO;
        }
    }
}
