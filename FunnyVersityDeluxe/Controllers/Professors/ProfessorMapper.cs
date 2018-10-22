using FVD.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunnyVersityDeluxe.Controllers.Professors
{
    public class ProfessorMapper
    {
        public ProfessorDTO ToDTO(Professor professor)
        {
            var professorDTO = new ProfessorDTO();
            professorDTO.ID = professor.ID;
            professorDTO.FirstName = professor.FirstName;
            professorDTO.LastName = professor.LastName;

            return professorDTO;
        }
    }
}
