namespace BootCamp.Chapter
{
    internal class Person
    {
        private string _name;
        private decimal _amount;
        private Account _balance;

        public Person(string name, Account balance)
        {
            _name = name;
            _balance = balance;
        }

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