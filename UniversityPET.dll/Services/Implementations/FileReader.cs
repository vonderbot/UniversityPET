using System.IO;
using UniversityPET.dll.Services.Interfaces;

namespace UniversityPET.dll.Services.Implementations
{
    public class FileReader : IReader
    {
        private readonly string _path;

        public FileReader(string path)
        {
            _path = path;
        }

        public string Read()
        {
            using var sr = new StreamReader(_path);
            return sr.ReadToEnd();
        }
    }
}