using System;
using UniversityPET.dll;

namespace UniversityPET
{
    internal class Program
    {
        private static void Main()
        {
            //задаём путь к файлу с которого хотим читать
            var path = @"D:\GitHub\NURE.txt";

            //создаём сериализатор(json конвертор), ридер, райтер 
            var serializator = new Serializator<University>();
            var reader = new FileReader(path);
            var writer = new FileWriter(path);

            //создаём один сервис для всех функций
            var databaseService = new TxtDatabaseService<University>(writer, reader, serializator);

            //через сервис записываем в файл наш университет, используя инициализатор университета
            //databaseService.Write(NureUniversityInitializer.Create());

            //считываем универ из файла и запихиваем в переменную
            var nure = databaseService.Read();

            //инициализируем сервис для работы с универом
            var universityService = new UniversityService(nure);

            //используем сервис для работы с универом
            var itm_19_2 = universityService.GetGroupByName("ITM-19-2");

            var twoStudentsWithBiggestGrade = universityService.GetTwoStudentsWithBiggestGrade();

            var mentorWithLowestSalary = universityService.GetMentorWithLowestSalary();

            var mentorsWithDragonInGroup = universityService.GetMentorsWithDragonInGroup();

            universityService.Foo1();

            Console.ReadKey();
        }
    }
}