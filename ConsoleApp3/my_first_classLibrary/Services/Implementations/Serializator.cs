using Newtonsoft.Json;
using UniversityPET.dll.Services.Interfaces;

namespace UniversityPET.dll.Services.Implementations
{
    public class Serializator<T> : ISerializator<T> where T : class
    {
        public string Serialize(T obj) => JsonConvert.SerializeObject(obj);
        public T Deserialize(string buffer) => JsonConvert.DeserializeObject<T>(buffer);
    }
}