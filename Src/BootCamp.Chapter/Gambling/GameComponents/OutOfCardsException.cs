using System;

namespace BootCamp.Chapter.Gambling
{
    public class OutOfCardsException : Exception
    {
        public OutOfCardsException() : base($"Deck is empty!")
        {
        }
    }
}