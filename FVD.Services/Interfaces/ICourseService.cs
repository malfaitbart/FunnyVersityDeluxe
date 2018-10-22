using FVD.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace FVD.Services.Interfaces
{
    public interface ICourseService
    {
        ICollection<Course> GetAllCourses();
        Course GetCourseByID(int id);
        Course CreateCourse(string name, double studyPoints, string category, int professorID);
        Course UpdateCourse(int id, string name, double studyPoints, string category, int professorID);
        string DeleteCourse(int id);
    }
}
