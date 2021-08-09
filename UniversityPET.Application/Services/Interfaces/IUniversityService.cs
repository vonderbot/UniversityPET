using System.Collections.Generic;
using UniversityPET.Core.Models.Implementations;

namespace UniversityPET.Application.Services.Interfaces
{
    public interface IUniversityService
    {
        public IEnumerable<Mentor> GetMentorsWithDragonInGroup();
        public Group GetGroupByName(string name);
        public IEnumerable<Student> GetTwoStudentsWithBiggestGrade();
        public Mentor GetMentorWithLowestSalary();
        public void Foo1();
        public void UniversityName();
        public void AllGroupsSortedByFaculty();
        public void AllInformationAboutGroup(string groupName);
        public void GroupGeneralInformation(string groupName);
        public void GroupMentor(string groupName);
        public void GroupStudents(string groupName);
    }
}