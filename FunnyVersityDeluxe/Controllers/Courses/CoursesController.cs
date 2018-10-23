using FVD.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FunnyVersityDeluxe.API.Controllers.Courses
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService courseService;
        private readonly CourseMapper courseMapper;

        public CoursesController(ICourseService courseService, CourseMapper courseMapper)
        {
            this.courseService = courseService;
            this.courseMapper = courseMapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CourseDTO>> GetAll()
        {
            var result = courseService.GetAllCourses();
            List<CourseDTO> courseDTOs = new List<CourseDTO>();
            foreach (var course in result)
            {
                courseDTOs.Add(courseMapper.ToDTO(course));
            }
            return courseDTOs;
        }

        [HttpGet("{ID}", Name = "GetCourse")]
        public ActionResult<CourseDTO> GetCourseByID(int id)
        {
            var result = courseService.GetCourseByID(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(courseMapper.ToDTO(result));
        }

        [HttpPost]
        public ActionResult<CourseDTO> CreateProfessor([FromBody] CourseDTO_Create courseToCreate)
        {
            var input = courseService.CreateCourse(courseToCreate.Name, courseToCreate.StudyPoints, courseToCreate.Category, courseToCreate.ProfessorID);
            if (input == null)
            {
                return NotFound();
            }
            return CreatedAtRoute("GetCourse", new { id = input.ID }, courseMapper.ToDTO(input));
        }

        [HttpPut]
        public IActionResult UpdateCourse([FromBody] CourseDTO courseToUpdate)
        {
            var course = courseService.GetCourseByID(courseToUpdate.ID);
            if (course == null)
            {
                return NotFound();
            }
            courseService.UpdateCourse(courseToUpdate.ID, courseToUpdate.Name, courseToUpdate.StudyPoints, courseToUpdate.Category, courseToUpdate.ProfessorID);
            return NoContent();
        }

        [HttpDelete("{ID}")]
        public IActionResult DeleteCourse(int id)
        {
            var course = courseService.GetCourseByID(id);
            if(course == null)
            {
                return NotFound();
            }
            courseService.DeleteCourse(id);
            return NoContent();
        }
    }
}