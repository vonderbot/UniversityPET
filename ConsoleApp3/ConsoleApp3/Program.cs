using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using ClassLibrary;

namespace first_project
{
    internal class Program
    {
        private static void Main()
        {
            var universityService = new UniversityService(new NureUniversityInitializer().Create());

            var itm_19_2 = universityService.GetGroupByName("ITM-19-2");

            var twoStudentsWithBiggestGrade = universityService.GetTwoStudentsWithBiggestGrade();

            var mentorWithLowestSalary = universityService.GetMentorWithLowestSalary();

            var mentorsWithDragonInGroup = universityService.GetMentorsWithDragonInGroup();

            universityService.Foo1();


            Console.ReadKey();
        }
    }
}