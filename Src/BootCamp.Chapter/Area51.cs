using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class Area51
    {
        private List<Account> accounts = new List<Account>();
        const string login = "login";
        const string create = "create";
        const string quit = "quit";
        public void Demo()
        {
            string answer = "";
            while (answer != quit)
            {
                answer = LoginCreateOrQuit();
                switch (answer)
                {
                    case login:
                        Login();
                        break;
                    case create:
                        Create();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Terminating Program!");
                        break;
                }  
            }
        }

        private string LoginCreateOrQuit()
        {

            string answer = string.Empty;
            bool dontKnowAnswer = true;

            while (dontKnowAnswer)
            {
                Console.Clear();
                Console.WriteLine("Login\r\nCreate\r\nQuit");
                Console.Write("Please choose one: ");
                answer = Console.ReadLine();
                dontKnowAnswer = AnswerParser(answer);
            }
            return answer.ToLower();

        }
        private void Login()
        {

        }
        private void Create()
        {

        }
        private void Quit()
        {

        }
        private bool AnswerParser(string answer)
        {
            switch (answer.ToLower())
            {
                case login:
                    return false;
                case create:
                    return false;
                case quit:
                    return false;
                default:
                    return true;
            }
        }
    }
}
