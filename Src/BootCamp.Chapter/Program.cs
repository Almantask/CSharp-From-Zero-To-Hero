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
        }
    }
}
