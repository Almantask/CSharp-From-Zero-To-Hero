using BootCamp.Chapter.Gambling;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class HandTest
    {
        // The constructor cannot be tested because cards is protected. 

        // AddCards cannot be tested because the return type is void and Cards cannot be read outside the class. 

        [Fact]
        public void Reveal_Given_Empty_list_Returns_Empty_List()
        {
            var hand = new Hand();
            var expected = new List<Card> { }; 

            var actual = hand.Reveal();

            Assert.Equal(expected, actual); 
        }
        

    }
}
