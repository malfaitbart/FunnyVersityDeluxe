using FVD.Domain;
using FVD.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace FVD.Services
{
    public class CourseService : ICourseService
    {
        private readonly List<Course> courses;

        public CourseService()
        {
            this.courses = new List<Course>() {
                {new Course(1, "class01", 12D, "math", 1) },
                {new Course(2, "hoofdsteden", 5.2, "aardrijkskunde", 3) }
            };
        }

        public ICollection<Course> GetAllCourses()
        {
            return courses;
        }

        public Course GetCourseByID(int id)
        {
            if (!courses.Where(item => item.ID == id).Any())
            {
                return null;
            }
            Course course = courses.Where(item => item.ID == id).First();
            return course;
        }

        public Course UpdateCourse(int id, string name, double studyPoints, string category, int professorID)
        {
            var course = courses.Where(item => item.ID == id).First();
            courses[id - 1] = new Course(id, name, studyPoints, category, professorID);
            return courses[id - 1];
        }

        public Course CreateCourse(string name, double studyPoints, string category, int professorID)
        {
            var course = new Course(courses.Count + 1, name, studyPoints, category, professorID);
            courses.Add(course);
            return course;
        }

        public string DeleteCourse(int id)
        {
            Course course = courses.Where(item => item.ID == id).First();
            courses.Remove(course);
            return "OK";
        }

    }
}
