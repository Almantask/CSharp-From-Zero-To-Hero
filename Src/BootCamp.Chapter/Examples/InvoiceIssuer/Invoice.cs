namespace BootCamp.Chapter.Examples.InvoiceIssuer
{
    public struct Invoice
    {
        private readonly string Name;
        private readonly decimal Amount;

        public Invoice(string name, in decimal amount)
        {
            Name = name;
            Amount = amount;
        }

        public override string ToString() => $"{Name} - {Amount}";
    }
}