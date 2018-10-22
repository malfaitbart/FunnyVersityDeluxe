using FVD.Domain;
using FVD.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace FVD.Services
{
    public class ProfessorService : IProfessorService
    {
        private readonly List<Professor> professorsList;
        public ProfessorService()
        {
            //this.dB_Context = dB_Context;
            professorsList = new List<Professor>()
            {
                new Professor(1, "Prof", "Barabas"),
                new Professor(2, "Prof", "Gobelijn"),
                new Professor(3, "Prof", "Zonnebloem")
            };
        }

        public ICollection<Professor> GetAllProfessors()
        {
            return professorsList;
        }

        public Professor GetProfessorById(int id)
        {
            if (!professorsList.Where(prof => prof.ID == id).Any())
            {
                return null;
            }
            Professor professor = professorsList.Where(prof => prof.ID == id).First();
            return professor;
        }

        public Professor CreateProfessor(string firstName, string lastName)
        {
            var newID = professorsList.Count()+1;
            if (newID == 0) { newID = 1; }

            var newProfessor = new Professor(newID, firstName, lastName);
            professorsList.Add(newProfessor);

            return newProfessor;
        }

        public string DeleteProfessor(int id)
        {
            Professor professor = professorsList.Where(prof => prof.ID == id).First();
            professorsList.Remove(professor);
            return "OK";
        }

        public Professor UpdateProfessor(int id, string firstName, string lastName)
        {
            var professor = professorsList.Where(prof => prof.ID == id).First();
            professorsList[id - 1] = new Professor(id, firstName, lastName);
            return professorsList[id - 1];
        }
    }
}
