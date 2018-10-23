using System.Collections.Generic;

namespace FVD.Domain
{
    public static class DB_Courses
    {
        public static List<Course> courses = new List<Course>()
        {
                {new Course("class01", 12D, "math", 1) },
                {new Course("hoofdsteden", 5.2, "aardrijkskunde", 2) }
        };
    }
}
