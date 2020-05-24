using System;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter.Gambling.Poker
{
    public class Poker : CardGame
    {
        private Dictionary<PokerCombo.Sets, Func<IEnumerable<Card>, int>> _comboChecks;

        public Poker()
        {
            _comboChecks = new Dictionary<PokerCombo.Sets, Func<IEnumerable<Card>, int>>
            {
                // Order matters.
                { PokerCombo.Sets.RoyalFlush, PokerCombo.CalculateRoyalFlushScore},
                { PokerCombo.Sets.StraightFlush, PokerCombo.CalculateStraightFlushScore},
                { PokerCombo.Sets.FourOfAKind, PokerCombo.CalculateFourOfAKindScore},
                { PokerCombo.Sets.FullHouse, PokerCombo.CallculateFullHouseScore},
                { PokerCombo.Sets.Flush, PokerCombo.CalculateFlushScore},
                { PokerCombo.Sets.Straight, PokerCombo.CalculateStraightScore},
                { PokerCombo.Sets.TrheeOfAKind, PokerCombo.CalculateThreeOfAKindScore},
                { PokerCombo.Sets.TwoPair, PokerCombo.CalculateTwoPairScore},
                { PokerCombo.Sets.Pair, PokerCombo.CalculatePairScore},
                { PokerCombo.Sets.HighCard, PokerCombo.CalculateHighCardScore}
            };
        }

        public override IEnumerable<Player> GetWinners()
        {
            if (!Players.Any()) return new Player[0];

            var playersWithCombos = new Dictionary<Player, PokerCombo>();

            foreach (var player in Players)
            {
                var cards = player.Hand.Reveal();
                var combo = FindCombo(cards);
                playersWithCombos.Add(player, combo);
            }

            var playersByScore = playersWithCombos.OrderByDescending(kvp => kvp.Value);
            var highestScore = playersByScore.First().Value;

            var winners = playersByScore.Where(p => p.Value == highestScore)
                                        .Select(p => p.Key);
            
            return winners.ToList();
        }

        private PokerCombo FindCombo(IEnumerable<Card> cards)
        {
            foreach (var comboCheck in _comboChecks)
            {
                var calculateScore = comboCheck.Value;
                var score = calculateScore(cards);
                var isSuccessfulCombo = score > 0;
                if (isSuccessfulCombo)
                {
                    var set = comboCheck.Key;
                    return new PokerCombo(set, score);
                }
            }

            throw new InvalidGameStateException("Ran out of possible combos.");
        }
    }
}
