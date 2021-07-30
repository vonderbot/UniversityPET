using System.Collections.Generic;

namespace University.dll
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