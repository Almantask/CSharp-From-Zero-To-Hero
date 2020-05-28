﻿using System;

namespace TestingRandom
{
    public class DiceRoller
    {
        private readonly IRandomizer _randomizer;

        public DiceRoller(IRandomizer randomizer)
        {
            _randomizer = randomizer;
        }

        public int Roll(string diceExpression)
        {
            var expressionParts = diceExpression.Split('d');
            var dieCount = Convert.ToInt32(expressionParts[0]);
            var sideCount = Convert.ToInt32(expressionParts[1]);

            var sum = 0;
            
            for (var i = 0; i < dieCount; i++)
            {
                sum += _randomizer.Next(sideCount) + 1;
            }

            return sum;
        }
    }
}
