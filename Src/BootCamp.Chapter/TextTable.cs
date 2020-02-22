using System;
using System.Text;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Part 1.
    /// </summary>
    public class TextTable
    {
        private readonly string _message;
        private readonly int _padding;
        private readonly int _longestWordSize;
        private readonly char _cornerChar = '+';
        private readonly char _horizontalBorderChar = '-';
        private readonly char _verticalBorderChar = '|';
        private readonly char _emptySpace = ' ';
        private readonly string messageDivider = Environment.NewLine;

        public TextTable(string message, int padding)
        {
            _message = message;
            _padding = padding;
            _longestWordSize = FindLongestWord();
        }

        public string Build()
        {
            if (!Test.IsStringValid(_message))
            {
                return string.Empty;
            }

            var result = string.Empty;
            result += AddHorizontalBorder();
            result += AddVerticalPadding(_padding);
            result += AddText();
            result += AddVerticalPadding(_padding);
            result += AddHorizontalBorder();

            return result;
        }

        private string AddText()
        {
            string[] words = _message.Split(messageDivider);
            StringBuilder text = new StringBuilder();

            foreach (string word in words)
            {
                text
                    .Append(_verticalBorderChar)
                    .Append(_emptySpace, _padding)
                    .Append(word)
                    .Append(_emptySpace, _longestWordSize - word.Length)
                    .Append(_emptySpace, _padding)
                    .Append(_verticalBorderChar)
                    .Append(Environment.NewLine);
            }
            return text.ToString();
        }

        private string AddHorizontalBorder()
        {
            string spacePadding = new string(_horizontalBorderChar, _longestWordSize + (_padding * 2));
            string horizontalBorder = $"{_cornerChar}{spacePadding}{_cornerChar}{Environment.NewLine}";
            return horizontalBorder;
        }

        private string AddVerticalPadding(int linesNumber)
        {
            StringBuilder verticalPadding = new StringBuilder();
            for (int i = 0; i < linesNumber; i++)
            {
                string spacePadding = new string(_emptySpace, _longestWordSize + (_padding * 2));
                verticalPadding
                    .Append(_verticalBorderChar)
                    .Append(spacePadding)
                    .Append(_verticalBorderChar)
                    .Append(Environment.NewLine);
            }
            return verticalPadding.ToString();
        }

        private int FindLongestWord()
        {
            int size = 0;
            foreach (string word in _message.Split(messageDivider))
            {
                if (word.Length > size)
                {
                    size = word.Length;
                }
            }

            return size;
        }
    }
}