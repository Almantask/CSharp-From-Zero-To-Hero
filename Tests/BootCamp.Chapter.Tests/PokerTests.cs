using BootCamp.Chapter.Gambling;
using BootCamp.Chapter.Gambling.Poker;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class PokerTests
    {
        [Fact]
        public void GetWinners_Given_List_Players_Returns_Winnner()
        {
            var player1 = new Player("player1", new PokerHand());
            player1.Hand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Ace));
            player1.Hand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.King));
            player1.Hand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Queen));
            player1.Hand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Jack));
            player1.Hand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Ten));

            var player2 = new Player("player2", new PokerHand());
            player2.Hand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Six));
            player2.Hand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Five));
            player2.Hand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Four));
            player2.Hand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Three));
            player2.Hand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Two));

            var game = new Poker();
            game.AddPlayer(player1);
            game.AddPlayer(player2);

            var expected = new List<Player> { player1 }; 
            
            var actual = game.GetWinners();

            Assert.Equal(expected, actual); 

        }
    }
}
