using System;
using System.Collections.Generic;
using System.Linq;
using UniversityPET.dll.Models.Implementations;

namespace UniversityPET.dll.Services.Implementations
{
    public class UniversityService
    {
        private readonly University _university;

        public UniversityService(University university)
        {
            _university = university;
        }

        public IEnumerable<Mentor> GetMentorsWithDragonInGroup()
        {
            return _university.Groups
                    .Where(g => g.Students.Exists(s => s.Sex == 'D'))
                    .Select(g => g.Mentor)
                ;
        }
        public Group GetGroupByName(string name)
        {
            return _university.Groups.Find(g => g.Name == name);
        }
        public IEnumerable<Student> GetTwoStudentsWithBiggestGrade()
        {
            return _university.Groups
                    .SelectMany(g => g.Students)
                    .OrderByDescending(s => s.Grade)
                    .Take(2)
                ;
        }
        public Mentor GetMentorWithLowestSalary()
        {
            return _university.Groups
                    .Select(g => g.Mentor)
                    .OrderBy(m => m.Salary)
                    .First()
                ;
        }
        //StudentsWithoutLastOneAndAgeMoreThirty
        public void Foo1()
        {
            _university.Groups
                .Where(gr => gr.Students.Exists(s => s.Sex == 'D' && gr.Mentor.Sex == 'F'))
                //.Where(g => g.Mentor.Sex == 'F')
                .SelectMany(g => g.Students)
                .Where(s => s.Age > 30)
                .OrderByDescending(s => s.Grade)
                .ThenByDescending(s => s.Name)
                .SkipLast(1)
                .ToList()
                .ForEach(s => Console.WriteLine($"Student: {s.Name}, Grade: {s.Grade}, Age: {s.Age}"))
                ;
        }
    }
    
}