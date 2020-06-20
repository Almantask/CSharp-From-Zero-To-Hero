using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace BootCamp.Chapter.Examples.SevereViolation
{
    public interface ILocatable
    {
        Vector3 Location { get; }
    }

    public class BrokenCarGood : ILocatable
    {
        public Vector3 Location { get; }
        public float KmTraveled { get; }

        public BrokenCarGood(Vector3 location, float kmTraveled)
        {
            Location = location;
            KmTraveled = kmTraveled;
        }
    }
}
