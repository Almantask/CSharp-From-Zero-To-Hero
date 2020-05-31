using BootCamp.Chapter.Gambling;
using BootCamp.Chapter.Gambling.Poker;
using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class PokerTests
    {
        [Theory]
        [MemberData(nameof(PokerExpectations))]
        public void GetWinners_Given_List_Players_Returns_ExpectedWinnner((Poker game, List<Player> expectedWinner) buildGame)
        {
            (Poker game, List<Player> expectedWinner) = buildGame;

            var winners = game.GetWinners();

            winners.Should().Contain(expectedWinner);
        }

        [Fact]
        public void GetWinners_Given_No_Players_Throws_InvalidGameStateException()
        {
            var game = new Poker();

            Action action = () => game.GetWinners();

            Assert.Throws<InvalidGameStateException>(action);
        }

        public static IEnumerable<object[]> PokerExpectations
        {
            get
            {
                yield return new object[] { BuildGameWithAWinner() };
                yield return new object[] { BuildGameWithADraw() };
                yield return new object[] { BuildGameWithSameCombo() };
            }
        }

        private static object BuildGameWithSameCombo()
        {
            var player1 = new Player("player1", new PokerHand());
            player1.Hand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Seven));
            player1.Hand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Six));
            player1.Hand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Five));
            player1.Hand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Four));
            player1.Hand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Three));

            var player2 = new Player("player2", new PokerHand());
            player2.Hand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Six));
            player2.Hand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Five));
            player2.Hand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Four));
            player2.Hand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Three));
            player2.Hand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Two));

            var game = new Poker();
            game.AddPlayer(player1);
            game.AddPlayer(player2);

            return (game, new List<Player> { player1 });
        }

        public static (Poker, List<Player>) BuildGameWithAWinner()
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

            return (game, new List<Player> { player1 });
        }

        public static (Poker, List<Player>) BuildGameWithADraw()
        {
            var player1 = new Player("player1", new PokerHand());
            player1.Hand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Ace));
            player1.Hand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.King));
            player1.Hand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Queen));
            player1.Hand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Jack));
            player1.Hand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Ten));

            var player2 = new Player("player2", new PokerHand());
            player2.Hand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Ace));
            player2.Hand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.King));
            player2.Hand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Queen));
            player2.Hand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Jack));
            player2.Hand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Ten));

            var game = new Poker();
            game.AddPlayer(player1);
            game.AddPlayer(player2);

            return (game, new List<Player> { player1, player2 });
        }
    }
}