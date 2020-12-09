using System;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var credentials = new Credentials("Tom", "Tom123");
            Console.WriteLine(credentials.Password);

            const string testFile = @"test.txt";
            const string EmptyFile = @"E:\Users\ke.li.TE\Documents\GitHub\CSharp-From-Zero-To-Hero\Tests\BootCamp.Chapter.Tests\Input\Files\TomTom123Credentials.txt";
            var credentialsManager = new CredentialsManager(EmptyFile);
            //var oldContents = File.ReadAllLines(EmptyFile);
            //Console.WriteLine(oldContents.Length);
            credentialsManager.Register(credentials);
            bool isLogin = credentialsManager.Login(credentials);
            //bool isContain = File.ReadAllLines(EmptyFile).ToString().Contains(oldContents.ToString());
            Console.WriteLine(isLogin);
            //Console.WriteLine(File.ReadAllLines(EmptyFile).Length);




        }
    }
}
