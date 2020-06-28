using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class SiteRegisterAndLoginSim
    { 
        public void Simulation()
        {
            Console.WriteLine("Program Start");
            CredentialsManager credentials_manager = new CredentialsManager(@$"C:\Users\Matthew\source\repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Credentials\Credentials.txt");
            Console.WriteLine("Creating new user!");
            var user = new Credentials("Matt_C#","YouCantReadThis");
            Console.WriteLine($"User Details: {user.Username},{user.Password}\n");
            Console.WriteLine("Attempting to Register User!");
            credentials_manager.Register(user);

            Console.WriteLine("\n-----------------------------------\n");
            Console.WriteLine("Attempting to register new user with same Username");
            var user2 = new Credentials("Matt_C#","DifferentPassword");
            credentials_manager.Register(user2);

            Console.WriteLine("\n-----------------------------------\n");
            Console.WriteLine($"Attempting Login of {user.Username}!");
            credentials_manager.Login(user);
            Console.WriteLine("Program End");
            Console.ReadLine();
        }   
    }
}
