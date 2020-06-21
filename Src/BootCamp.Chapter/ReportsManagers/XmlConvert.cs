using BootCamp.Chapter.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace BootCamp.Chapter.ReportsManagers
{
    public static class XmlConvert
    {
        public static string SerializeObject(object value)
        {
            if (value == null)
            {
                return string.Empty;
            }

            try
            {
                var serializer = new XmlSerializer(value.GetType());
                var stringWriter = new StringWriter();
                using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings
                {
                    Indent = true
                }))
                {
                    xmlWriter.WriteProcessingInstruction("xml", "version='1.0'");
                    serializer.Serialize(xmlWriter, value);
                    return stringWriter.ToString();
                }
            }
            catch (Exception ex)
            {
                throw new SerializationException($"Failed to serialize {value} to XML.", ex);
            }
        }

        public static T DeserializeFile<T>(string path)
            where T : class
        {
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                using (var reader = XmlReader.Create(path))
                {
                    return serializer.Deserialize(reader) as T;
                }
            }
            catch (Exception ex)
            {
                throw new SerializationException($"Failed to deserialize file {path} to {typeof(T).Name}.", ex);
            }
        }

        public static T DeserializeObject<T>(string xml)
            where T : class
        {
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                using (var reader = new StringReader(xml))
                {
                    return serializer.Deserialize(reader) as T;
                }
            }
            catch (Exception ex)
            {
                throw new SerializationException($"Failed to deserialize xml {xml} to {typeof(T).Name}.", ex);
            }
        }
    }
}
