using System.IO;
using Newtonsoft.Json;

namespace BootCamp.Chapter.Examples.Json.JsonExtensions
{
    public static class JsonConvertExtensions
    {
        public static T DeserializeFile<T>(string json)
        {
            var content = File.ReadAllText(json);
            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}
