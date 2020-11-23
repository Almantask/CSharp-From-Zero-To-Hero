using System;
using System.Text;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Part 1.
    /// </summary>
    public static class TextTable
    {
        /*

         Input: "Hello", 0
           +-----+
           |Hello|
           +-----+
           
         Input: $"Hello{Environment.NewLine}World!", 0
           +------+
           |Hello |
           |World!|
           +------+
           
         Input: "Hello", 1
           +-------+
           |       |
           | Hello |
           |       |
           +-------+

         */

        private static string SymbolAtCorner = "+";
        private static char CharAlongHorizontalBorder = '-';
        private static string SymbolAlongVerticalBorder = "|";
        private static string SymbolForEmptySpace = string.Empty;

        /// <summary>
        /// Build a table for given message with given padding.
        /// Padding means how many spaces will a message be wrapped with.
        /// Table itself is made of: "+-" symbols. 
        /// </summary>
        public static string Build(string message, int padding)
        {
            if (string.IsNullOrWhiteSpace(message)) return string.Empty;
            var lines = message.Split(Environment.NewLine);
            var maxLineLength = ArrayOperations.ReturnLongestStringLengthInArray(lines);
            return BuildTable(lines, maxLineLength, padding);
        }

        private static string BuildTable(string[] lines, int maxLineLength, int padding)
        {
            var linesWithPaddedLines = AddPaddedLinesTo(lines, padding);
            if (lines.Length >= 10) return BuildTableWithSb(linesWithPaddedLines, maxLineLength, padding);
            return BuildTableWithStr(linesWithPaddedLines, maxLineLength, padding);
        }

        private static string BuildTableWithSb(string[] lines, int maxLineLength, int padding)
        {
            var table = new StringBuilder();
            var maxPrintableWidth = maxLineLength + 2 * padding;
            table.Append(BuildHeaderFooterLine(maxPrintableWidth));
            foreach (var line in lines)
            {
                table.Append(BuildContentLine(line, maxLineLength, padding));
            }
            table.Append(BuildHeaderFooterLine(maxPrintableWidth));
            return table.ToString();
        }

        private static string BuildTableWithStr(string[] lines, int maxLineLength, int padding)
        {
            var table = string.Empty;
            var maxPrintableWidth = maxLineLength + (2 * padding);
            table += BuildHeaderFooterLine(maxPrintableWidth);
            foreach (var line in lines)
            {
                table += BuildContentLine(line, maxLineLength, padding);
            }
            table += BuildHeaderFooterLine(maxPrintableWidth);
            return table;
        }

        private static string[] AddPaddedLinesTo(string[] arr, int count)
        {
            var results = new string[arr.Length];
            arr.CopyTo(results, 0);
            for (var i = 0; i < count; i++)
            {
                results = ArrayOperations.InsertAt(results, SymbolForEmptySpace, 0);
                results = ArrayOperations.InsertAt(results, SymbolForEmptySpace, results.Length);
            }
            return results;
        }
        private static string BuildContentLine(string content, int maxLineLength, int padding)
        {
            return $"{SymbolAlongVerticalBorder}{SymbolForEmptySpace.PadRight(padding)}" +
                   $"{content.PadRight(maxLineLength)}" + 
                   $"{SymbolForEmptySpace.PadRight(padding)}{SymbolAlongVerticalBorder}{Environment.NewLine}";
        }

        private static string BuildHeaderFooterLine(int maxPrintWidth)
        {
            return $"{SymbolAtCorner}{new string(CharAlongHorizontalBorder, maxPrintWidth)}{SymbolAtCorner}{Environment.NewLine}";
        }

    }
}
