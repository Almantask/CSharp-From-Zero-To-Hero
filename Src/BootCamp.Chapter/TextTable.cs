using System;
using System.Text;

namespace BootCamp.Chapter
{
    public class TextTable
    {
        private readonly string _message;
        private readonly int _padding;

        public TextTable(string message, int padding)
        {
            _message = message;
            _padding = padding; 
        }
        public string Build()
        {
            if (string.IsNullOrEmpty(_message))
            {
                return "";
            }
            // make a array so I can find the longest word. 

            var arrayOfLines = _message.Split(Environment.NewLine);

            // Find length of longest word 
            var lengthLongestWord = GetLongestWordLength(arrayOfLines);

            // print table 

            var table = new StringBuilder();
            AddTopOrBottomLineToTable(_padding, lengthLongestWord, table);
            AddEmptyLinesToTable(_padding, lengthLongestWord, table);
            AddTextToTable(_padding, arrayOfLines, lengthLongestWord, table);
            AddEmptyLinesToTable(_padding, lengthLongestWord, table);
            AddTopOrBottomLineToTable(_padding, lengthLongestWord, table);
            return table.ToString();

        }

        private static void AddTextToTable(int padding, string[] arrayOfLines, int lengthLongestWord, StringBuilder table)
        {
            foreach (var word in arrayOfLines)
            {
                table.Append("|");
                table.Append(String.Empty.PadRight(padding, ' '));
                table.Append(word);
                table.Append(String.Empty.PadRight(lengthLongestWord - word.Length + padding, ' '));
                table.Append("|");
                table.Append(Environment.NewLine);
            }
        }

        private static int GetLongestWordLength(string[] arrayOfLines)
        {
            var lengthLongestWord = 0;
            foreach (var word in arrayOfLines)
            {
                if (word.Length > lengthLongestWord)
                {
                    lengthLongestWord = word.Length;
                }
            }

            return lengthLongestWord;
        }

        private static void AddEmptyLinesToTable(int padding, int lengthLongestWord, StringBuilder table)
        {
            for (int i = 0; i < padding; i++)
            {
                table.Append("|");
                table.Append($"{ String.Empty.PadRight(lengthLongestWord + 2 * padding, ' ')}");
                table.Append("|");
                table.Append($"{Environment.NewLine}");
            }

        }

        private static void AddTopOrBottomLineToTable(int padding, int lengthLongestWord, StringBuilder table)
        {
            table.Append("+");
            table.Append($"{String.Empty.PadRight(lengthLongestWord + 2 * padding, '-')}");
            table.Append("+");
            table.Append($"{Environment.NewLine}");
        }

    }
}
