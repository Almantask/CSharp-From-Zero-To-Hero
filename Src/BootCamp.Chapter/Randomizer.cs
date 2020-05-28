﻿using System;

namespace TestingRandom
{
    public class Randomizer : IRandomizer
    {
        private readonly Random _random = new Random();
        
        public int Next(int maximum)
        {
            return _random.Next(maximum);
        }
    }
}
