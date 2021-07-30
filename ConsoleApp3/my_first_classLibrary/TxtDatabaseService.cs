namespace UniversityPET.dll
{
    public class TxtDatabaseService<T>
    {
        private readonly IWriter _writer;
        private readonly IReader _reader;
        private readonly ISerializator<T> _serializator;

        public TxtDatabaseService(IWriter writer, IReader reader, ISerializator<T> serializator)
        {
            _writer = writer;
            _reader = reader;
            _serializator = serializator;
        }

        public void Write(T obj) => _writer.Write(_serializator.Serialize(obj));
        public T Read() => _serializator.Deserialize(_reader.Read());
    }
}