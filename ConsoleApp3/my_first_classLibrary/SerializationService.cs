using Newtonsoft.Json;

namespace University.dll
{
    public class SerializationService<T>
    {
        public string Serialize(T obj) => JsonConvert.SerializeObject(obj);
        public T Deserialize(string buffer) => JsonConvert.DeserializeObject<T>(buffer);
    }
}