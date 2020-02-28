using System;
using System.Text;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print each of the statistical output using Text Table with padding 3:
            // - FindHighestBalanceEver
            // - FindPersonWithBiggestLoss
            // - FindRichestPerson
            // - FindMostPoorPerson

            //string message = $"Hello{Environment.NewLine}World!";
            //string message = $"333{Environment.NewLine}1{Environment.NewLine}22";
            //string message = "one";
            //string[] newMessage = message.Split(new string[] { System.Environment.NewLine }, System.StringSplitOptions.None);
            //Console.WriteLine(message);
            //Console.WriteLine(newMessage.Length);
            //Console.WriteLine(newMessage[0].Length);
            //Console.WriteLine(newMessage[1].Length);
            //Console.WriteLine(newMessage[2].Length);
            //Array.ForEach(newMessage, Console.WriteLine);
            //Console.WriteLine(TextTable.LongestStringIndex(newMessage));
            //int padding = 0;
            //int padding = 2;
            //StringBuilder sb = new StringBuilder();
            //sb.Append("+").Append('-', newMessage[TextTable.LongestStringIndex(newMessage)].Length + padding).AppendLine("+");
            //sb.Append("+").Append(' ', newMessage[TextTable.LongestStringIndex(newMessage)].Length + padding).Append("+");
            //Console.WriteLine(sb.ToString());
            //Console.WriteLine($"|{newMessage[0]}|");

            Console.WriteLine(TextTable.Build($"Hello{Environment.NewLine}World!", 1));

        }
    }
}
