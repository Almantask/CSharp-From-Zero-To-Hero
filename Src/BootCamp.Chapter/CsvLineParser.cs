using System;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter
{
    internal class CsvLineParser
    {
        private string _line;
        private Stack<string> _tokens;

        public CsvLineParser(string line)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                throw new ArgumentException("Line must be provided.", nameof(line));
            }

            _line = line.Trim();
            _tokens = new Stack<string>();
        }

        public string ParseNextField()
        {
            if (NeedToIgnoreWhitespace())
            {
                _line = _line[1..];
                return ParseNextField();
            }

            if (NeedToPushQuoteToken())
            {
                PushQuoteToken();
                return ParseNextField();
            }

            if (NeedToHandleDelimiter())
            {
                var token = _tokens.Pop();
                if (token == "\"" && InQuotedField())
                {
                    throw new CsvParsingException();
                }

                _line = _line[1..];
                return token;
            }

            if (InQuotedField() && _tokens.Count > 1)
            {
                _tokens.Pop();
                return _tokens.Pop();
            }

            PushDefaultToken();

            return ParseNextField();
        }

        private bool NeedToHandleDelimiter()
        {
            return _line.Length > 0 && _line[0] == ',';
        }

        private bool NeedToPushQuoteToken()
        {
            return _line.Length > 0 && _line[0] == '"';
        }

        private bool NeedToIgnoreWhitespace()
        {
            return !InQuotedField() && _line.Length > 0 && char.IsWhiteSpace(_line[0]);
        }

        private bool InQuotedField()
        {
            return _tokens.Count > 0 && _tokens.First() == "\"";
        }

        private void PushDefaultToken()
        {
            var nextTokenIndex = _line.IndexOf(',');
            nextTokenIndex = nextTokenIndex == -1 || InQuotedField() ? _line.IndexOf('\"') : nextTokenIndex;

            if (nextTokenIndex == -1)
            {
                _tokens.Push(_line);
                _line = "";
                return;
            }

            _tokens.Push(_line[..nextTokenIndex]);
            _line = _line[nextTokenIndex..];
        }

        private void PushQuoteToken()
        {
            _tokens.Push("\"");
            _line = _line[1..];
        }
    }
}
