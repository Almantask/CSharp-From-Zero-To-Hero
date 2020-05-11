namespace BootCamp.Chapter.Examples.InvoiceIssuer
{
    public class BankAccount
    {
        public string Id { get; }
        public decimal Balance { get; set; }

        public BankAccount(string id, decimal balance)
        {
            Id = id;
            Balance = balance;
        }
    }
}