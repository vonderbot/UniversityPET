using System.IO;
using UniversityPET.dll.Services.Interfaces;

namespace UniversityPET.dll.Services.Implementations
{
    public class FileWriter : IWriter
    {
        private readonly string _path;

        public FileWriter(string path)
        {
            _path = path;
        }

        public void Write(string buffer)
        {
            using var sw = new StreamWriter(_path);
            sw.WriteLine(buffer);
        }
    }
}