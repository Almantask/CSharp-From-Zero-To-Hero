using System;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter.Gambling.Poker
{
    /// <summary>
    /// All combos available in Poker.
    /// Other combos have a score, which is based on how high the cards make them.
    /// If combo is not existing, score is 0.
    /// </summary>
    public class PokerCombo : IComparable<PokerCombo>
    {
        public enum Sets
        {
            HighCard,
            Pair,
            TwoPair,
            TrheeOfAKind,
            Straight,
            Flush,
            FullHouse,
            FourOfAKind,
            StraightFlush,
            RoyalFlush
        }

        public Sets Set { get; }
        public int Score { get; }

        public PokerCombo(Sets set, int score)
        {
            Set = set;
            Score = score;
        }

        public static bool operator >(PokerCombo combo1, PokerCombo combo2)
            => combo1.Set > combo2.Set ||
               (combo1.Set == combo2.Set) && combo1.Score > combo2.Score;

        public static bool operator <(PokerCombo combo1, PokerCombo combo2)
            => combo1.Set < combo2.Set ||
               (combo1.Set == combo2.Set) && combo1.Score < combo2.Score;

        public static bool operator ==(PokerCombo combo1, PokerCombo combo2)
            => combo1.Set == combo2.Set &&
               combo1.Score == combo2.Score;

        public static bool operator !=(PokerCombo combo1, PokerCombo combo2)
            => !(combo1 == combo2);

        public static int CalculateRoyalFlushScore(IEnumerable<Card> cards)
        {
            if (cards.Any(card => card.Rank == Card.Ranks.Ace)
                && cards.Any(card => card.Rank == Card.Ranks.King)
                && cards.Any(card => card.Rank == Card.Ranks.Queen)
                && cards.Any(card => card.Rank == Card.Ranks.Jack)
                && cards.Any(card => card.Rank == Card.Ranks.Ten)
                && (cards.GroupBy(card => card.Suite).Count() == 1))
            {
                return 12;
            }

            return 0;
        }

        public static int CalculateStraightFlushScore(IEnumerable<Card> cards)
        {
            if (!CheckIFAllCardsHaveSameSuit(cards))
            {
                return 0;
            }

            var sorted = cards.OrderBy(card => card.Rank).ToArray();
            var startValue = (int)sorted.First().Rank;
            for (int i = 0; i < cards.Count() - 1; i++)
            {
                if ((int)sorted[i].Rank != startValue + i)
                {
                    return 0;
                }
            }

            return 22;
        }

        public static int CalculateFourOfAKindScore(IEnumerable<Card> cards)
        {
            if (!AmountOfOneRank(cards, 4))
            {
                return 0;
            }
            return 21;
        }

        public static int CallculateFullHouseScore(IEnumerable<Card> cards)
        {
            if (!AmountOfOneRank(cards, 3) && !AmountOfOneRank(cards, 2))
            {
                return 0;
            }
            return 20;
        }

        public static int CalculateFlushScore(IEnumerable<Card> cards)
        {
            if (!CheckIFAllCardsHaveSameSuit(cards))
            {
                return 0;
            }

            return 19;
        }

        public static int CalculateStraightScore(IEnumerable<Card> cards)
        {
            if (!CheckIFAllCardsHaveSameSuit(cards))
            {
                return 0;
            }

            return 18;
        }

        public static int CalculateThreeOfAKindScore(IEnumerable<Card> cards)
        {
            if (!AmountOfOneRank(cards, 3))
            {
                return 0;
            }

            return 17;
        }

        public static int CalculateTwoPairScore(IEnumerable<Card> cards)
        {
            if (cards.GroupBy(h => h.Rank).Where(g => g.Count() == 2).Count() != 2)
            {
                return 0;
            }

            return 16;
        }

        public static int CalculatePairScore(IEnumerable<Card> cards)
        {
            if (cards.GroupBy(h => h.Rank).Where(g => g.Count() == 2).Count() != 1)
            {
                return 0;
            }

            return 15;
        }

        public static int CalculateHighCardScore(IEnumerable<Card> cards)
        {
            var sorted = cards.OrderByDescending(card => card.Rank).ToArray();
            var highestCard = sorted.First().Rank;

            switch (highestCard)
            {
                case Card.Ranks.Ace:
                    return 14;

                case Card.Ranks.King:
                    return 13;

                case Card.Ranks.Queen:
                    return 12;

                case Card.Ranks.Jack:
                    return 11;

                case Card.Ranks.Ten:
                    return 10;

                case Card.Ranks.Nine:
                    return 9;

                case Card.Ranks.Eight:
                    return 8;

                case Card.Ranks.Seven:
                    return 7;

                case Card.Ranks.Six:
                    return 6;

                case Card.Ranks.Five:
                    return 5;

                case Card.Ranks.Four:
                    return 4;

                case Card.Ranks.Three:
                    return 3;

                case Card.Ranks.Two:
                    return 2;
            }

            return 0;
        }

        public int CompareTo(PokerCombo other)
        {
            return this.Score.CompareTo(other.Score);
        }

        public override bool Equals(object obj)
        {
            return obj is PokerCombo combo &&
                   Set == combo.Set &&
                   Score == combo.Score;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Set, Score);
        }

        private static bool AmountOfOneRank(IEnumerable<Card> cards, int limit)
        {
            return cards.GroupBy(h => h.Rank).Where(g => g.Count() == limit).Any();
        }

        private static bool CheckIFAllCardsHaveSameSuit(IEnumerable<Card> cards)
        {
            return cards.GroupBy(card => card.Suite).Count() != 1;
        }
    }
}