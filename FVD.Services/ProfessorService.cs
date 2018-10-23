using FVD.Domain;
using FVD.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FVD.Services
{
    public class ProfessorService : IProfessorService
    {
        public ProfessorService()
        {
        }

        public ICollection<Professor> GetAllProfessors()
        {
            //return DB_Professors.professors;
            return DB_Professors.professors;
        }

        public Professor GetProfessorById(int id)
        {
            if (!DB_Professors.professors.Where(prof => prof.ID == id).Any())
            {
                return null;
            }
            Professor professor = DB_Professors.professors.Where(prof => prof.ID == id).First();
            return professor;
        }

        public Professor CreateProfessor(string firstName, string lastName)
        {
            var newID = DB_Professors.professors.Count()+1;
            if (newID == 0) { newID = 1; }

            var newProfessor = new Professor(firstName, lastName);
            DB_Professors.professors.Add(newProfessor);

            return newProfessor;
        }

        public string DeleteProfessor(int id)
        {
            Professor professor = DB_Professors.professors.Where(prof => prof.ID == id).First();
            DB_Professors.professors.Remove(professor);
            return "OK";
        }

        public Professor UpdateProfessor(int id, string firstName, string lastName)
        {
            var professorIndex = DB_Professors.professors.FindIndex(prof => prof.ID == id);
            DB_Professors.professors[professorIndex]= new Professor(id, firstName, lastName);
            return DB_Professors.professors[professorIndex];
        }
    }
}
