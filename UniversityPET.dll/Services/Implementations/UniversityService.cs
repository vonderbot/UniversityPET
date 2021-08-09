using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
        public void UniversityName()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"University: {_university.Name}\n");
            Console.ResetColor();
        }
        public void AllGroupsSortedByFaculty()
        {
            _university.Groups.OrderBy(s => s.Faculty)
                .ToList()
                .ForEach(s => this.AllInformationAboutGroup(s.Name))
                ;
        }
        public void AllInformationAboutGroup(string groupName)
        {
            if (_university.Groups.Exists(g => g.Name == groupName))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                GroupGeneralInformation(groupName);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                GroupMentor(groupName);
                Console.ResetColor();
                GroupStudents(groupName);
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine($"The group \"{groupName}\" doesn`t exist.\n");
            }
        }
        public void GroupGeneralInformation(string groupName)
        {
            if (_university.Groups.Exists(g => g.Name == groupName)){
                _university.Groups
                    .Where(g => g.Name == groupName)
                    .ToList()
                    .ForEach(s => Console.WriteLine($"Group name: {s.Name}, Faculty: {s.Faculty}"))
                    ;
            }
            else
            {
                Console.WriteLine($"The group \"{groupName}\" doesn`t exist.\n");
            }
        }
        public void GroupMentor(string groupName)
        {
            if (_university.Groups.Exists(g => g.Name == groupName))
            {
                _university.Groups
                    .Where(g => g.Name == groupName)
                    .Select(g => g.Mentor)
                    .ToList()
                    .ForEach(s => Console.WriteLine($"Mentor: {s.Name}"))
                    ;
            }
            else
            {
                Console.WriteLine($"The group \"{groupName}\" doesn`t exist.\n");
            }
        }
        public void GroupStudents(string groupName)
        {
            if (_university.Groups.Exists(g => g.Name == groupName))
            {
                _university.Groups
                    .Where(g => g.Name == groupName)
                    .SelectMany(g => g.Students)
                    .OrderByDescending(s => s.Grade)
                    .ToList()
                    .ForEach(s => Console.WriteLine($"Student name: {s.Name}, Grade: {s.Grade}"))
                    ;
            }
            else
            {
                Console.WriteLine($"The group \"{groupName}\" doesn`t exist.\n");
            }
        }
    }
    
}