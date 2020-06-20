using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Models
{
    public class TimesModel
    {
        public List<HourCountEarnedCurrency> Times { get; set; }
        public int RushHour { get; set; }

        public TimesModel(List<HourCountEarnedCurrency> times, int rushHour)
        {
            Times = times;
            RushHour = rushHour;
        }
    }
}
