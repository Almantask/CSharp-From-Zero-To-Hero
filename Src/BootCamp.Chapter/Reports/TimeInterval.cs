using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class TimeInterval : IEquatable<TimeInterval>
    {
        public TimeSpan Start { get; }
        public TimeSpan End { get; }

        public TimeInterval(TimeSpan start, TimeSpan end)
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

        public bool Contains(TimeSpan moment)
        {
            return moment >= Start && moment <= End;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as TimeInterval);
        }

        public bool Equals(TimeInterval other)
        {
            return other != null &&
                   Start.Equals(other.Start) &&
                   End.Equals(other.End);
        }

        public static bool operator ==(TimeInterval left, TimeInterval right)
        {
            return EqualityComparer<TimeInterval>.Default.Equals(left, right);
        }

        public static bool operator !=(TimeInterval left, TimeInterval right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Start, End);
        }
    }
}