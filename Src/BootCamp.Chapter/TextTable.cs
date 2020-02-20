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

        public TextTable(string message, int padding = 0)
        {
            if(string.IsNullOrEmpty(message))
            {
                Console.WriteLine("Message can not be null or empty!");
            }
            _message = message;
            _padding = padding;
            _longestWordSize = FindLongestWord();
        }

        public void Build()
        {
            var result = string.Empty;
            result += AddHorizontalBorder();
            result += AddVerticalPadding(_padding);
            result += AddText();
            result += AddVerticalPadding(_padding);
            result += AddHorizontalBorder();
            Console.WriteLine(result);
        }

        private string AddText()
        {
            string[] words = _message.Split(messageDivider);
            string text = string.Empty;

            foreach(string word in words)
            {
                text += _verticalBorderChar;
                text += new string(_emptySpace, _padding);
                text += word;
                text += new string(_emptySpace, _longestWordSize - word.Length);
                text += new string(_emptySpace, _padding);
                text += _verticalBorderChar;
                text += Environment.NewLine;
            }
            return text;
        }

        private string AddHorizontalBorder()
        {
            string spacePadding = new string(_horizontalBorderChar, _longestWordSize + (_padding * 2));
            string horizontalBorder = $"{_cornerChar}{spacePadding}{_cornerChar}{Environment.NewLine}";
            return horizontalBorder;
        }

        private string AddVerticalPadding(int linesNumber = 0)
        {
            string verticalPadding = string.Empty;
            for (int i = 0; i < linesNumber; i++)
            {
                string spacePadding = new string(_emptySpace, _longestWordSize + (_padding * 2));
                verticalPadding += $"{_verticalBorderChar}{spacePadding}{_verticalBorderChar}{Environment.NewLine}";
            }
            return verticalPadding;
        }

        private int FindLongestWord()
        {
            int size = 0;
            foreach(string word in _message.Split(messageDivider))
            {
                if(word.Length > size)
                {
                    size = word.Length;
                }
            }
            return size;
        }
    }
}
