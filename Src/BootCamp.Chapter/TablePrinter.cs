using System;
using System.Text;

namespace BootCamp.Chapter
{
    public class TablePrinter
    {
        private readonly string _text;
        private readonly int _padding;
        private readonly char _sideTop;
        private readonly char _sideLeft;
        private readonly char _corner;

        public TablePrinter(string text)
        {
            _text = text;
            _padding = 0;
            _sideTop = '-';
            _sideLeft = '|';
            _corner = '+';
        }

        public TablePrinter(string text, int padding, char sideTop, char sideLeft, char corner) : this(text)
        {
            _padding = padding;
            _sideTop = sideTop;
            _sideLeft = sideLeft;
            _corner = corner;
        }

        public static string DisplayTable(TablePrinter printer)
        {
            var table = new StringBuilder();
            AddTopLineToTable(printer, table);
            AddEmptyLinesToTable(printer, table);
            AddTextToTable(printer, table);
            AddEmptyLinesToTable(printer, table);
            AddBottomLineToTable(printer, table);
            return table.ToString();
        }

        private static void AddTopLineToTable(TablePrinter printer, StringBuilder table)
        {
            table.Append(printer._corner);
            table.Append($"{String.Empty.PadRight(printer._text.Length + 2 * printer._padding, printer._sideTop)}");
            table.Append(printer._corner);
            table.Append($"{Environment.NewLine}");
        }

        private static void AddBottomLineToTable(TablePrinter printer, StringBuilder table)
        {
            table.Append(printer._corner);
            table.Append($"{String.Empty.PadRight(printer._text.Length + 2 * printer._padding, printer._sideTop)}");
            table.Append(printer._corner);
        }

        private static void AddEmptyLinesToTable(TablePrinter printer, StringBuilder table)
        {
            for (int i = 0; i < printer._padding; i++)
            {
                table.Append(printer._sideLeft);
                table.Append($"{ String.Empty.PadRight(printer._text.Length + 2 * printer._padding, ' ')}");
                table.Append(printer._sideLeft);
                table.Append($"{Environment.NewLine}");
            }
        }

        private static void AddTextToTable(TablePrinter printer, StringBuilder table)
        {
            table.Append(printer._sideLeft);
            table.Append(String.Empty.PadRight(printer._padding, ' '));
            table.Append(printer._text);
            table.Append(String.Empty.PadRight(printer._padding, ' '));
            table.Append(printer._sideLeft);
            table.Append(Environment.NewLine);
        }
    }
}