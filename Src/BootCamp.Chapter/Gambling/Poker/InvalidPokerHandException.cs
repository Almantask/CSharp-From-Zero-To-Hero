using System;

namespace BootCamp.Chapter.Gambling.Poker
{
    public class InvalidPokerHandException : Exception
    {
        public InvalidPokerHandException(int size) : base($"Invalid hand size. Attempted to have {size}, when max allowed is {PokerHand.MaxSize}")
        {
        }
    }
}