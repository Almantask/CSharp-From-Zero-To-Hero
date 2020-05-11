using System;

namespace BootCamp.Chapter.Examples.Cards
{
    public class OutOfCardsException : Exception
    {
        public OutOfCardsException(int index, int actualCount) : base($"Tried to get {index}th card, but deck only has {actualCount}.")
        {
        }
    }
}