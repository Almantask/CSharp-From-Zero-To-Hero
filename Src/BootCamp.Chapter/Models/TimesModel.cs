using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Models
{
    public class TimesModel
    {
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
