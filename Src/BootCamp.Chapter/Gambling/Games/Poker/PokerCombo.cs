using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace BootCamp.Chapter.Gambling.Poker
{
    /// <summary>
    /// All combos available in Poker.
    /// Other combos have a score, which is based on how high the cards make them.
    /// If combo is not existing, score is 0.
    /// </summary>
    public class PokerCombo : IComparable<PokerCombo>, IComparable
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
            return 12;
        }

        public static int CalculateStraightFlushScore(IEnumerable<Card> cards)
        {
            return 11;
        }

        public static int CalculateFourOfAKindScore(IEnumerable<Card> cards)
        {
            return 0;
        }

        public static int CallculateFullHouseScore(IEnumerable<Card> cards)
        {
            return 0;
        }

        public static int CalculateFlushScore(IEnumerable<Card> cards)
        {
            return 0;
        }

        public static int CalculateStraightScore(IEnumerable<Card> cards)
        {
            return 0;
        }

        public static int CalculateThreeOfAKindScore(IEnumerable<Card> cards)
        {
            return 0;
        }

        public static int CalculateTwoPairScore(IEnumerable<Card> cards)
        {
            return 0;
        }

        public static int CalculatePairScore(IEnumerable<Card> cards)
        {
            return 0;
        }

        public static int CalculateHighCardScore(IEnumerable<Card> cards)
        {
            return 0;
        }

        public int CompareTo(PokerCombo other)some
        {
            if (this.Score < other.Score)
            {
                return -1;
            }
            
            if (this.Score == other.Score)
            {
                return 0; 
            }

            return 1; 
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

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
