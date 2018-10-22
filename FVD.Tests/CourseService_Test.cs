using FVD.Domain;
using FVD.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FVD.Tests
{
    public class CourseService_Test
    {
        [Fact]
        public void GivenACourseService_WhenCallingGetAllCourses_ThenRecieveAListWithAllCourses()
        {
            //Given
            var professorService = new CourseService();
            //When
            ICollection<Course> actual = professorService.GetAllCourses();
            //Then
            Assert.Equal(2, actual.Count);
        }

        [Fact]
        public void GivenACourseService_WhenCallingGetCourse_ThenRecieveCourse()
        {
            //Given
            var courseService = new CourseService();
            //When
            var actual = courseService.GetCourseByID(1);
            //Then
            Assert.Equal("class01", actual.Name);
        }

        [Fact]
        public void GivenACourseService_WhenCallingGetCourseWithNonExistingID_ThenRecieveNull()
        {
            //Given
            var courseService = new CourseService();
            //When
            var actual = courseService.GetCourseByID(5);
            //Then
            Assert.Null(actual);
        }

        [Fact]
        public void GivenACourseService_WhenCallingAddCourse_ThenRecieveTheAddedCourse()
        {
            //Given
            var courseService = new CourseService();
            //When
            var actual = courseService.CreateCourse("test", 1.5, "world", 3);
            //Then
            Assert.Equal("test", actual.Name);
        }

        [Fact]
        public void GivenACourseService_WhenCallingUpdateCourse_TheRecieveTheUpdatedCourse()
        {
            //Given
            var courseService = new CourseService();
            //When
            var update = courseService.UpdateCourse(1, "class01", 5.6, "demo", 2);
            var actual = courseService.GetCourseByID(1);
            //Then
            Assert.Equal("demo", actual.Category);
        }

        [Fact]
        public void GivenACourseService_WhenCallingDeleteCourse_ThenCourseIsDeleted()
        {
            //Given
            var courseService = new CourseService();
            //When
            courseService.DeleteCourse(1);
            var actual = courseService.GetAllCourses();
            //Then
            Assert.Equal(1, actual.Count);
        }

    }
}
