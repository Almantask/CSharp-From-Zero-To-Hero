using System;

namespace BootCamp.Chapter
{
    class Program
    {
        private const string credentialsFile = @"..\..\..\Database\Userdata.db";
        private const string credentialsFile2 = @"Input/Files/EmptyCredentials.txt";

        static void Main(string[] args)
        {
            Credentials credentialsOne = new Credentials("Hello", "Kai");
            Credentials credentialsTwo = new Credentials("Adam", "Kl6627");
            Credentials credentialsThree = new Credentials("David", "HJk1##88ba");

            CredentialsManager credentialsManager = new CredentialsManager(credentialsFile);
            credentialsManager.Register(credentialsOne);
            credentialsManager.Register(credentialsTwo);

            //Console.WriteLine(credentialsOne != credentialsTwo);
            //Console.WriteLine(credentialsOne.ToString());

            //var password = Console.ReadLine();
            //Console.WriteLine(password);

            //var encodedPassword = Encoder.Encode(password);
            //Console.WriteLine(encodedPassword);
        }
    }
}
