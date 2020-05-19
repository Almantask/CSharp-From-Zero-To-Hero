using BootCamp.Chapter.Gambling;
using System;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class PlayerTests
    {
        [Fact]
        public void New_Given_Arguments_For_Name_Sets_Name()
        {
            var name = "John Doe";
            var hand = new Hand();

            var player = new Player(name, hand);

            Assert.Equal(player.Name, name);
        }

        [Fact]
        public void New_Given_Arguments_For_Hand_Sets_Hand()
        {
            var name = "John Doe";
            var hand = new Hand();

            var player = new Player(name, hand);

            Assert.Equal(player.Hand, hand);
        }

        [Fact]
        public void New_Given_Null_Name_Throws_ArgumentNullException()
        {
            string name = null;
            var hand = new Hand();

            Action action = () => new Player(name, hand);

            Assert.Throws<ArgumentNullException>(action); 
        }

        [Fact]
        public void New_Given_Null_Hand_Throws_ArgumentNullException()
        {
            string name = "Jon Doe";
            Hand hand = null; 

            Action action = () => new Player(name, hand);

            Assert.Throws<ArgumentNullException>(action);
        }
    }
}