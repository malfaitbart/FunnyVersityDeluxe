﻿using FVD.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace FunnyVersityDeluxe.Controllers.Professors
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorsController : ControllerBase
    {
        private readonly IProfessorService professorService;
        private readonly ProfessorMapper professorMapper;

        public ProfessorsController(IProfessorService professorService, ProfessorMapper professorMapper)
        {
            this.professorService = professorService;
            this.professorMapper = professorMapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProfessorDTO>> GetAll()
        {
            var result = professorService.GetAllProfessors();
            List<ProfessorDTO> professorDTOs = new List<ProfessorDTO>();
            foreach (var professor in result)
            {
                professorDTOs.Add(professorMapper.ToDTO(professor));
            }
            return Ok(professorDTOs);
        }

        [HttpGet("{ID}", Name = "GetProfessor")]
        public ActionResult<ProfessorDTO> GetProfessorByID(int id)
        {
            var result = professorService.GetProfessorById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(professorMapper.ToDTO(result));
        }

        [HttpPost]
        public ActionResult<ProfessorDTO> CreateProfessor([FromBody] ProfessorDTO professorToCreate)
        {
            var input = professorService.CreateProfessor(professorToCreate.FirstName, professorToCreate.LastName);
            return CreatedAtRoute("GetProfessor", new { id = input.ID }, professorMapper.ToDTO(input));
        }

        [HttpPut]
        public IActionResult UpdateProfessor([FromBody] ProfessorDTO professorToUpdate)
        {
            var professor = professorService.GetProfessorById(professorToUpdate.ID);
            if (professor == null)
            {
                return NotFound();
            }
            professorService.UpdateProfessor(professorToUpdate.ID, professorToUpdate.FirstName, professorToUpdate.LastName);
            return NoContent();
        }

        [HttpDelete("{ID}")]
        public IActionResult DeleteProfessor(int id)
        {
            var professor = professorService.GetProfessorById(id);
            if (professor == null)
            {
                return NotFound();
            }
            professorService.DeleteProfessor(id);
            return NoContent();
        }
    }
}