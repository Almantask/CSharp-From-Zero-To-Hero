using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Credentials credentialsOne = new Credentials("David", "HJk1##88ba");
            Credentials credentialsTwo = new Credentials("Adam", "Kl6627");
            Credentials credentialsThree = new Credentials("David", "HJk1##88ba");

            Console.WriteLine(credentialsOne != credentialsTwo);
            Console.WriteLine(credentialsOne.ToString());

            var password = Console.ReadLine();
            Console.WriteLine(password);

            var encodedPassword = Encoder.Encode(password);
            Console.WriteLine(encodedPassword);
        }
    }
}
