using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BootCamp.Chapter.Models
{
    [XmlRoot("Times")]
    public class TimesModel
    {
        [XmlElement("Times")]
        public List<Time> Times { get; set; }
        public int RushHour { get; set; }

        public TimesModel()
        {

        }

        public TimesModel(List<Time> times, int rushHour)
        {
            Times = times;
            RushHour = rushHour;
        }
    }
}
