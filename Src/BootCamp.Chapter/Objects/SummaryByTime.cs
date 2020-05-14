using System;

namespace BootCamp.Chapter.Objects
{
    public readonly struct SummaryByTime
    {
        // public DateTimeOffset DateTime { get; }
        public int Hour { get; }
        public decimal Earn { get; }
        public int Count { get; }
        
        public SummaryByTime(int hour, decimal earn, int count)
        {
            Hour = hour;
            Earn = earn;
            Count = count;
        }
    }
}
