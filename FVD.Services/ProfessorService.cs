using FVD.Domain;
using FVD.Services.Interfaces;
using System;
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
                new Professor("Prof", "Barabas"),
                new Professor("Prof", "Gobelijn"),
                new Professor("Prof", "Zonnebloem")
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

            var newProfessor = new Professor(firstName, lastName);
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
            var professorIndex = professorsList.FindIndex(prof => prof.ID == id);
            professorsList[professorIndex]= new Professor(id, firstName, lastName);
            return professorsList[professorIndex];
        }
    }
}
