using System.Collections.Generic;

namespace ClassLibrary
{
    public class University
    {
        public string Name { get; set; }
        public double GraduatingPrice { get; set; }
        public List<Group> Groups { get; set; }

    }
}