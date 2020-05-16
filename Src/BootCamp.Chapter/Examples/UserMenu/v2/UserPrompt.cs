using System;

namespace BootCamp.Chapter.Examples.UserMenu.v2
{
    public interface IUserPrompt
    {
        string ReadLine();
        void WriteLine(string message);
    }

    public class UserPrompt : IUserPrompt
    {
        public string ReadLine() => Console.ReadLine();
        public void WriteLine(string message) => Console.WriteLine(message);
    }

}
