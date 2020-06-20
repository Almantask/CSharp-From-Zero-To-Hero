using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Models
{
    public class TimesModel
    {
        public List<HourCountEarned> Times { get; set; }
        public string RushHour { get; set; }

        public TimesModel(List<HourCountEarned> times, string rushHour)
        {
            Times = times;
            RushHour = rushHour;
        }
    }
}
