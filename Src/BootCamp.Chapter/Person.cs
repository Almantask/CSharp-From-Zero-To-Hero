namespace BootCamp.Chapter
{
    public class Person
    {
        private readonly string _name;
        private readonly decimal _amount;
        

        public Person(string name, decimal amount)
        {
            _name = name;
            _amount = amount;
        }

        public decimal GetAmount()
        {
            return _amount; 
        }


    }
}