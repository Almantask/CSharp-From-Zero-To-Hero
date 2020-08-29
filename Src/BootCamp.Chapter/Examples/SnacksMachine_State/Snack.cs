namespace BootCamp.Chapter.Examples.SnacksMachine_State
{
    public class Snack
    {
        public string Name { get; }
        public int Id { get; }
        public decimal Price { get; set; }

        public Snack(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}