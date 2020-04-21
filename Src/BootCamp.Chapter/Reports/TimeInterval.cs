using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class TimeInterval
    {
        private readonly DateTime Start;
        private readonly DateTime End;

        public TimeInterval(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
        }

        public TimeSpan TotalTime
        {
            get
            {
                return End - Start;
            }
        }

        public bool Contains(DateTime moment)
        {
            return moment >= Start && moment <= End;
        }
    }
}