using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var credentials = new Credentials("Tom", "123455");
            string s = "Tom,123455";
            Credentials.TryParse(s,out Credentials credit);
            Console.WriteLine(credit.Username);

            const string EmptyFile = @"EmptyCredentials.txt";
            var credentialsManager = new CredentialsManager(EmptyFile);
            credentialsManager.Register(credentials);
            var credentials1 = new Credentials("Tom", "123455");
            credentialsManager.Register(credentials1);
            bool isLogin = credentialsManager.Login(credentials);
            Console.WriteLine(isLogin);
        }
    }
}
