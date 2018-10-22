using FVD.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace FVD.Services.Interfaces
{
    public interface IProfessorService
    {
        ICollection<Professor> GetAllProfessors();
        Professor GetProfessorById(int id);
        Professor CreateProfessor(string firstName, string lastName);
        Professor UpdateProfessor(int id, string firstName, string lastName);
        string DeleteProfessor(int id);
    }
}
