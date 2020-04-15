using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
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
