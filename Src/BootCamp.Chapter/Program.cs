using System;
using System.IO;
using System.Text;

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
            //var oldContents = File.ReadAllLines(EmptyFile);
            //Console.WriteLine(oldContents.Length);
            credentialsManager.Register(credentials);
            bool isLogin = credentialsManager.Login(credentials);
            //bool like = File.ReadAllLines(EmptyFile).ToString().Contains(oldContents.ToString());
            Console.WriteLine(isLogin);
            //Console.WriteLine(File.ReadAllLines(EmptyFile).Length);

            string yanan = "Tom123";
            var bytes = Encoding.Unicode.GetBytes(yanan);
            foreach(var a in bytes)
            {
                Console.Write(a + " ");
            }
        }
    }
}
