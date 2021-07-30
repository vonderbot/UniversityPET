using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary
{
    public class Group
    {
        public string Name { get; set; }
        public string Faculty { get; set; }
        public Mentor Mentor { get; set; }
        public List<Student> Students { get; set; }

        public override string ToString()
        {
            return $"Group: {Name} with {Students.Count} students, Faculty: {Faculty}, Mentor: {Mentor.Name}";
        }
    }
}