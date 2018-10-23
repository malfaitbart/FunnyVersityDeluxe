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
            var professorDTO = new ProfessorDTO
            {
                ID = professor.ID,
                FirstName = professor.FirstName,
                LastName = professor.LastName
            };

            return professorDTO;
        }
    }
}
