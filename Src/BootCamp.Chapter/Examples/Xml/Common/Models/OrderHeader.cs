using System;

namespace BootCamp.Chapter.Examples.Xml.Common.Models
{
    public class OrderHeader
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string To { get; set; }
        public string Form { get; set; }
        public DateTime OrderedAt { get; set; }
    }
}
