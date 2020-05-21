using System;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter.Gambling
{
    public interface IDeck
    {
        Card DrawFromTop();
        Card DrawRandom();
        Card DrawAt(int index);
        void Shuffle();
    }

    public class Deck : IDeck
    {
        private readonly IList<Card> _cards;
        private int CurrentCardIndex => _cards.Count - 1;

        public Deck(IEnumerable<Card> cards)
        {
            _cards = cards?.ToList() ?? throw new ArgumentNullException(nameof(cards));
        }

        public Card DrawFromTop() => DrawAt(CurrentCardIndex);

        public Card DrawRandom() => DrawAt(Randomizer.Instance.Next(_cards.Count));

        public Card DrawAt(int index)
        {
            ValidateDeckSize(index);
            var card = _cards[index];
            _cards.RemoveAt(index);

            return card;
        }

        public void Shuffle() => _cards.Shuffle();

        private void ValidateDeckSize(int index)
        {
            
            if (_cards.Count == 0)
            {
                throw new OutOfCardsException();
            }
            if (index < 0 || index >= _cards.Count)
            {
                throw new IndexOutOfRangeException($"Cant pick a card at index {index} becouse deck size is {_cards.Count} and cant be less than 0");
            }
        }
    }
}