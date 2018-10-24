using FVD.Domain;
using FVD.Services;
using System.Collections.Generic;
using Xunit;

namespace FVD.Tests
{
    public class ProfessorService_Test
    {
        [Fact]
        public void GivenAProfessorService_WhenCallingGetAllProfessors_ThenRecieveAListWithAllProfessors()
        {
            //Given
            var professorService = new ProfessorService();
            //When
            ICollection<Professor> actual = professorService.GetAllProfessors();
            //Then
            Assert.Equal(3, actual.Count);
        }

        [Fact]
        public void GivenAProfessorService_WhenCallingGetProfessor_ThenRecieveProfessor()
        {
            //Given
            var professorService = new ProfessorService();
            //When
            var actual = professorService.GetProfessorById(1);
            //Then
            Assert.Equal("Gobelijn", actual.LastName);
        }

        [Fact]
        public void GivenAProfessorService_WhenCallingGetProfessorWithNonExistingID_ThenRecieveNull()
        {
            //Given
            var professorService = new ProfessorService();
            //When
            var actual = professorService.GetProfessorById(5);
            //Then
            Assert.Null(actual);
        }

        [Fact]
        public void GivenAProfessorService_WhenCallingAddProfessor_ThenRecieveTheAddedProfessor()
        {
            //Given
            var professorService = new ProfessorService();
            //When
            var actual = professorService.CreateProfessor("hello", "world");
            //Then
            Assert.Equal("world", actual.LastName);
        }

        [Fact]
        public void GivenAProfessorService_WhenCallingUpdateProfessor_TheRecieveTheUpdatedProfessor()
        {
            //Given
            var professorService = new ProfessorService();
            //When
            var update = professorService.UpdateProfessor(1, "bart", "simpson");
            var actual = professorService.GetProfessorById(1);
            //Then
            Assert.Equal("simpson", actual.LastName);
        }

        [Fact]
        public void GivenAProfessorService_WhenCallingDeleteProfessor_ThenProfessorIsDeleted()
        {
            //Given
            var professorService = new ProfessorService();
            //When
            professorService.DeleteProfessor(1);
            var actual = professorService.GetAllProfessors();
            //Then
            Assert.Equal(3, actual.Count);
        }
    }
}
