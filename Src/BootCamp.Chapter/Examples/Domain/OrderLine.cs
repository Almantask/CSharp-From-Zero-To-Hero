namespace BootCamp.Chapter.Examples.Domain
{
    public class OrderLine
    {
        public float Amount { get; }
        public float Price { get; }
        public Item Item { get; }

        public OrderLine(float amount, float price, Item item)
        {
            Amount = amount;
            Price = price;
            Item = item;
        }
    }
}
