﻿using System;

namespace TestingRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            var roller = new DiceRoller(new Randomizer());

            Console.WriteLine(roller.Roll("1d6"));
        }
    }
}
