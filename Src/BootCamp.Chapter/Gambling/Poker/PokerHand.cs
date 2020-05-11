using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Gambling.Poker
{
    public class PokerHand : Hand
    {
        public const int MaxSize = 5;

        public override void AddCards(params Card[] cards)
        {
            if (cards == null)
            {
                throw new ArgumentNullException(nameof(cards));
            }

            ValidateHandSize(cards);
            base.AddCards(cards);
        }

        private void ValidateHandSize(Card[] cards)
        {
            var newHandSize = Cards.Count + cards.Length;
            if (newHandSize > MaxSize)
            {
                throw new InvalidPokerHandException(newHandSize);
            }
        }
    }
}
