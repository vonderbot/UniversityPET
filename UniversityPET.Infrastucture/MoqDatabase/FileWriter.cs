using System.IO;
using UniversityPET.Core.Interfaces;

namespace UniversityPET.Infrastructure.MoqDatabase
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