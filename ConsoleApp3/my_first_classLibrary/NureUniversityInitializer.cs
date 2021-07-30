using System.Collections.Generic;

namespace ClassLibrary
{
    public class NureUniversityInitializer : IUniversityInitializer
    {
        public University Create()
        {
            return new()
            {
                Name = "NURE",
                GraduatingPrice = 22000.50,
                Groups = new List<Group>(new[]{new Group
                    {
                        Faculty = "CS",
                        Mentor = new Mentor
                        {
                            Age = 55,
                            Gender = 'M',
                            Salary = 830d,
                            Name = "Maria"
                        },
                        Name = "ITM-19-2",
                        Students = new List<Student>(new[]{new Student
                            {
                                Age = 20,
                                Gender = 'M',
                                Grade = 83,
                                Name = "Oleg"
                            },
                            new Student
                            {
                                Age = 30,
                                Gender = 'F',
                                Grade = 60,
                                Name = "Olegovna"
                            },
                            new Student
                            {
                                Age = 40,
                                Gender = 'M',
                                Grade = 35,
                                Name = "Olegovich"
                            },
                            new Student
                            {
                                Age = 50,
                                Gender = 'M',
                                Grade = 100,
                                Name = "Olegasse"
                            }
                        }),
                    },
                    new Group
                    {
                        Faculty = "CS",
                        Mentor = new Mentor
                        {
                            Age = 0,
                            Gender = 'F',
                            Salary = 450d,
                            Name = "Grisha"
                        },
                        Name = "ITM-19-1",
                        Students = new List<Student>(new[]{new Student
                            {
                                Age = 2000,
                                Gender = 'D',
                                Grade = 60,
                                Name = "Slavic"
                            },
                            new Student
                            {
                                Age = 22,
                                Gender = 'M',
                                Grade = 72,
                                Name = "Aliva"
                            },
                            new Student
                            {
                                Age = 35,
                                Gender = 'F',
                                Grade = 100,
                                Name = "Avila"
                            },
                            new Student
                            {
                                Age = 50,
                                Gender = 'M',
                                Grade = 100,
                                Name = "Nuruto"
                            }
                        }),
                    }
                })
            };
        }
    }
}