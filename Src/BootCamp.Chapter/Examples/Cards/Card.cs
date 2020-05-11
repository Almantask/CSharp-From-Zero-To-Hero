namespace BootCamp.Chapter.Examples.Cards
{
    public struct Card
    {
        public enum Suites
        {
            Clubs,
            Diamonds,
            Hearts,
            Spades
        }

        public enum Ranks
        {
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            Ace
        }

        public readonly Suites Suite;
        public readonly Ranks Rank;

        public Card(Suites suite, Ranks rank)
        {
            Suite = suite;
            Rank = rank;
        }

        public override string ToString() => $"{Rank} of {Suite}";
    }
}