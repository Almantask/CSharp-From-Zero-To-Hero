namespace BootCamp.Chapter.Examples.InvoiceIssuer
{
    public class Person
    {
        public string Name { get; }
        public int Age { get; }
        public decimal Salary { get; }
        public string Email { get; }
        public BankAccount BankAccount { get; }

        public Person(string name, int age, decimal salary, string email, BankAccount bankAccount)
        {
            Name = name;
            Age = age;
            Salary = salary;
            Email = email;
            BankAccount = bankAccount;
        }
    }
}