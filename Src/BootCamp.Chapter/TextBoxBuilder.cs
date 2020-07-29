using System;
using System.Text;

namespace BootCamp.Chapter
{
    public class TextBoxBuilder
    {
        private readonly string _message;
        private readonly TextTableAttribute _textTableAttributes;
        private readonly int _messageLength;
        private readonly int _numberOfLines;
        private readonly int _numberOfMainLine;
        private readonly string _paddingString;
        private StringBuilder sb = new StringBuilder();
        private const int DivideByTwo = 2;
        private const int AddOne = 1;

        public TextBoxBuilder(TextTableAttribute textTableAttributes, string message)
        {
            _textTableAttributes = textTableAttributes;
            _message = message;
            _messageLength = _message.Length + (_textTableAttributes.Padding * DivideByTwo);
            _numberOfLines = 3 + (_textTableAttributes.Padding * DivideByTwo);
            _numberOfMainLine = (_numberOfLines + AddOne) / DivideByTwo;
            _paddingString = new string(' ', _textTableAttributes.Padding);
        }

        public string BuildTextBox()
        {
            string topAndBottom = BuildTopAndBottomLines();
            string mainLine = BuildMainLine();
            string mainLineWithPadding = BuildMainLineWithPadding();
            string paddingLine = BuildPaddingLine();

            for (int i = 1; i < _numberOfLines + AddOne; i++)
            {
                if (i == 1 || i == _numberOfLines)
                {
                    sb.AppendLine(topAndBottom);
                }
                else if (i != _numberOfMainLine && _textTableAttributes.Padding != 0)
                {
                    sb.AppendLine(paddingLine);
                }
                else if (i == _numberOfMainLine && _textTableAttributes.Padding == 0)
                {
                    sb.AppendLine(mainLine);
                }
                else if (i == _numberOfMainLine && _textTableAttributes.Padding != 0)
                {
                    sb.AppendLine(mainLineWithPadding);
                }
            }
            return sb.ToString().Trim();
        }

        private string BuildTopAndBottomLines()
        {
            return $"{_textTableAttributes.Corner}{new String(_textTableAttributes.Horizontal, _messageLength)}{_textTableAttributes.Corner}";
        }

        private string BuildMainLine()
        {
            return $"{_textTableAttributes.Vertical}{_message}{_textTableAttributes.Vertical}";
        }

        private string BuildMainLineWithPadding()
        {
            return $"{_textTableAttributes.Vertical}{_paddingString}{_message}{_paddingString}{_textTableAttributes.Vertical}";
        }

        private string BuildPaddingLine()
        {
            return $"{_textTableAttributes.Vertical}{new string(' ', _messageLength)}{_textTableAttributes.Vertical}";
        }
    }
}