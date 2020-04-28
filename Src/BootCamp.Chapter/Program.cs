using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var tom = new Credentials("Tom", "Tom123");
            var joseph = new Credentials("Tom2", "1234");
            var passBank = new CredentialsManager("Passwords.txt");
            
            passBank.Register(tom);
            passBank.Register(joseph);

            Console.Read();
        }
    }
}
