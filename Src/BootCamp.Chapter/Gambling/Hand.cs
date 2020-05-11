using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Gambling
{
    public class Hand
    {
        protected List<Card> Cards { get; }

        public Hand()
        {
            Cards = new List<Card>();
        }

        public virtual void AddCards(params Card[] cards) => Cards.AddRange(cards);
        public IEnumerable<Card> Reveal() => Cards;
    }
}
