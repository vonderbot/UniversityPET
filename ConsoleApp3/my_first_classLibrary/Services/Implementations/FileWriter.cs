using System.IO;

namespace UniversityPET.dll
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