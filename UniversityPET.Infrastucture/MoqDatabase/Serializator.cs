using Newtonsoft.Json;
using UniversityPET.Core.Interfaces;

namespace UniversityPET.Infrastructure.MoqDatabase
{
    public class Serializator<T> : ISerializator<T> where T : class
    {
        public string Serialize(T obj) => JsonConvert.SerializeObject(obj);
        public T Deserialize(string buffer) => JsonConvert.DeserializeObject<T>(buffer);
    }
}