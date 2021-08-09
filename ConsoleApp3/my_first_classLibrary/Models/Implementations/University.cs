using System.Collections.Generic;

namespace UniversityPET.dll.Models.Implementations
{
    public class University
    {
        public string Name { get; set; }
        public double GraduatingPrice { get; set; }
        public List<Group> Groups { get; set; }

    }
}