using System;
using JSON = BootCamp.Chapter.Examples.Json;
using XML = BootCamp.Chapter.Examples.Xml;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoJson();
            DemoXml();
        }

        private static void DemoJson()
        {
            Console.WriteLine("---Json Demos---");
            JSON.Serialization.SerializeOrderDemo.Run();
            JSON.Deserialization.DeserializeOrderDemo.Run();
            JSON.Mapping.MappingDemo.Run();
        }

        private static void DemoXml()
        {
            Console.WriteLine("---Xml Demos---");
            XML.Serialization.SerializeOrderDemo.Run();
            XML.Deserialization.DeserializeOrderDemo.Run();
            XML.Mapping.MappingDemo.Run();
        }
    }
}
