using System.IO;

namespace University.dll
{
    public class FileWriter
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