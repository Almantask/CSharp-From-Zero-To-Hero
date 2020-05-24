using BootCamp.Chapter.Gambling;
using System;
using System.Collections.Generic;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class PlayerTests
    {
        [Fact]
        public void New_Given_Arguments_For_Name_Sets_Name_And_Hand()
        {
            var name = "John Doe";
            var hand = new Hand();

            var player = new Player(name, hand);

            Assert.Equal(player.Name, name);
            Assert.Equal(player.Hand, hand); 
        }

        

        [Theory]

        [MemberData(nameof(playersExpectations))]
        public void New_Given_Name_Or_Hand_Does_Not_Exist_Throws_ArgumentNullException(string name, Hand hand)
        {
            Action action = () => new Player(name, hand); 

            Assert.Throws<ArgumentNullException>(action); 
        }

        public static IEnumerable<object[]> playersExpectations
        {
            get
            {
                yield return new object[] { "John Doe", null };
                yield return new object[] { null, new Hand() };
            }
        }
    }
}