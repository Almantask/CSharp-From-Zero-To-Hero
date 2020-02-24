namespace BootCamp.Chapter
{
    internal class Person
    {
        private string _name;
        private Account _balance;

        public Person(string name, Account balance)
        {
            _name = name;
            _balance = balance;
        }
    }
}