//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using FunnyVersityDeluxe.Controllers.Professors;
//using FVD.Domain;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace FunnyVersityDeluxe.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProfessorController : ControllerBase
//    {
//        private readonly FVD.Domain.FVD_InMemory_DB fVDContext;
//        private readonly Professors.ProfessorMapper professorMapper;

//        public ProfessorController(FVD_InMemory_DB, Professors.ProfessorMapper professorMapper)
//        {
//            this.fVDContext = fVDContext;
//            this.professorMapper = professorMapper;

//            if (fVDContext.Professors.Count() == 0)
//            {
//                fVDContext.Professors.Add(new Professor { FirstName = "Bart", LastName = "Malfait" });
//                fVDContext.SaveChanges();
//            }
//        }

//        [HttpGet]
//        public ActionResult<List<Professor>> GetAll()
//        {
//            return fVDContext.Professors.ToList();
//        }

//        [HttpGet("{ID}", Name = "GetProfessor")]
//        public ActionResult<ProfessorDTO> GetByID(int id)
//        {
//            var item = fVDContext.Professors.Find(id);
//            if (item == null)
//            {
//                return NotFound();
//            }
//            return Ok(professorMapper.ToDTO(item));
//        }

//        [HttpPost]
//        public IActionResult Create(Professor professor)
//        {
//            fVDContext.Professors.Add(professor);
//            fVDContext.SaveChanges();

//            return CreatedAtRoute("GetProfessor", new { id = professor.ID }, professor);
//        }

//        [HttpPut("{ID}")]
//        public IActionResult Update(int id, Professor professor)
//        {
//            var toUpdate = fVDContext.Professors.Find(id);
//            if (toUpdate == null)
//            {
//                return NotFound();
//            }

//            toUpdate.FirstName = professor.FirstName;
//            toUpdate.LastName = professor.LastName;

//            fVDContext.Professors.Update(toUpdate);
//            fVDContext.SaveChanges();
//            return NoContent();

//        }

//        [HttpDelete("{ID}")]
//        public IActionResult Delete(int id)
//        {
//            var toDelete = fVDContext.Professors.Find(id);
//            if(toDelete == null)
//            {
//                return NotFound();
//            }

//            fVDContext.Professors.Remove(toDelete);
//            fVDContext.SaveChanges();
//            return NoContent();
//        }
//    }
//}