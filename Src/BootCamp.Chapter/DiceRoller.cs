﻿using System;
 using BootCamp.Chapter;

 namespace TestingRandom
{
    public class DiceRoller
    {
        // Don't edit this class to complete the bonus "Additional Testing / Mocks Practice" task.
        private readonly IRandomiser _randomizer;

        public DiceRoller(IRandomiser randomizer)
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
