using FVD.Data;
using FVD.Domain;
using FVD.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace FVD.Services
{
    public class CourseService : ICourseService
    {
        public CourseService()
        {
        }

        public ICollection<Course> GetAllCourses()
        {
            return DB_Courses.courses;
        }

        public Course GetCourseByID(int id)
        {
            if (!DB_Courses.courses.Any(item => item.ID == id))
            {
                return null;
            }
            Course course = DB_Courses.courses.Where(item => item.ID == id).First();
            return course;
        }

        public Course UpdateCourse(int id, string name, double studyPoints, string category, int professorID)
        {
            if (!DB_Professors.professors.Where(prof => prof.ID == professorID).Any())
            {
                return null;
            }

            var course = DB_Courses.courses.Where(item => item.ID == id).First();
            DB_Courses.courses[id - 1] = new Course(id, name, studyPoints, category, professorID);
            return DB_Courses.courses[id - 1];
        }

        public Course CreateCourse(string name, double studyPoints, string category, int professorID)
        {
            if(!DB_Professors.professors.Where(prof => prof.ID == professorID).Any())
            {
                return null;
            }
            var course = new Course(name, studyPoints, category, professorID);
            DB_Courses.courses.Add(course);
            return course;
        }

        public string DeleteCourse(int id)
        {
            Course course = DB_Courses.courses.Where(item => item.ID == id).First();
            DB_Courses.courses.Remove(course);
            return "OK";
        }

    }
}
