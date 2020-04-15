using System;
using System.Xml.Serialization;

namespace BootCamp.Chapter.Examples.Xml.Common.Models
{
    public class Item
    {
        [XmlElement(ElementName = "Name")]
        public string Nam { get; set; }
        public string Description { get; set; }
        public DateTime DataOfMaking { get; set; }
    }
}
