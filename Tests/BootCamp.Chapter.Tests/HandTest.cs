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

        [Fact]
        public void AddCards_Given_Empty_List_And_A_List_With_Elements_Returns_A_List_With_Elements()
        {
            var cardToBeAdded = new Card(Card.Suites.Clubs, Card.Ranks.Four) ;
            var hand = new Hand();
            var expected = new List<Card>() { new Card(Card.Suites.Clubs, Card.Ranks.Four) }; 

            hand.AddCards(cardToBeAdded);
            var actual = hand.Reveal();

            Assert.Equal(expected, actual); 
        }

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
