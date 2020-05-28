using System;
using TestingRandom;
using Xunit;

namespace TestingRandomTests
{
    public class DiceRollerTests
    {
        private DiceRoller _sut;

        public DiceRollerTests()
        {
            _sut = new DiceRoller(new Randomizer());
        }
        
        [Theory]
        [InlineData("fd6")]
        [InlineData("2df")]
        public void Roll_Throws_Format_Exception_For_Malformed_Input_String(string input)
        {
            void Act() => _sut.Roll(input);

            Assert.Throws<FormatException>(Act);
        }

        
        // TODO: Fix this test
        [Fact]
        public void Roll_Never_Out_Of_Range()
        {
            for (var i = 0; i < 100; i++)
            {
                var result = _sut.Roll("1d6");
                if (result < 1 || 6 < result)
                {
                    throw new Exception($"Result out of range: {result}");
                }
            }
        }
        
        // TODO: Figure out a way to test making sure the dice roller gets random numbers the right number of times
        // TODO: rolling "2d6" should call the randomizer twice, and pass in 6 to IRandomizer.Next(int)
    }
}
