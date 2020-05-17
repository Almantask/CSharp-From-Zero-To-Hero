using BootCamp.Chapter.Gambling;

namespace BootCamp.Chapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var cardToBeAdded = new Card(Card.Suites.Clubs, Card.Ranks.Four);
            var hand = new Hand(); 
            hand.AddCards(cardToBeAdded);
            var actual = hand.Reveal();
        }
    }
}