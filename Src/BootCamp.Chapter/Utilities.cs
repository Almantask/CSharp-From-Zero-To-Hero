using System;
using System.Text;

namespace BootCamp.Chapter
{
    internal static class Utilities
    {
        public static string PromptText(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static string PromptPassword(string message)
        {
            const char BackspaceKey = '\b';
            const char ReturnKey = '\r';
            const string PasswordBackspace = "\b\0\b\b\0\b";
            const string SmileyFace = "\x263A ";

            Console.WriteLine(message);
            var password = new StringBuilder();
            var enter = false;

            do
            {
                var key = Console.ReadKey(true);

                switch (key.KeyChar)
                {
                    case ReturnKey:
                        enter = false;
                        break;
                    case BackspaceKey:
                        Console.Write(PasswordBackspace);

                        if (password.Length > 0)
                        {
                            password.Remove(password.Length - 1, 1);
                        }

                        enter = true;
                        break;
                    default:
                        Console.OutputEncoding = Encoding.Unicode;
                        Console.Write(SmileyFace);
                        Console.OutputEncoding = Encoding.Default;
                        password.Append(key.KeyChar);
                        enter = true;
                        break;
                }
            } while (enter);

            Console.WriteLine("");
            return password.ToString();
        }
    }
}
