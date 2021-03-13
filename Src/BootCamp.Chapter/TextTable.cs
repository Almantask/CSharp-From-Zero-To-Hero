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

        /// <summary>
        /// Build a table for given message with given padding.
        /// Padding means how many spaces will a message be wrapped with.
        /// Table itself is made of: "+-" symbols. 
        /// </summary>
        /// 

        private static string SymbolAtCorner = "+";
        private static char CharAlongHorizontalBorder = '-';
        private static string SymbolAlongVerticalBorder = "|";
        private static char SymbolForEmptySpace = ' ';


        public static string Build(string message, int padding)
        {

            if (message == "") return "";

            string[] arr = Compare(message);
            StringBuilder sb = new StringBuilder();

            InsertHeadandFooterLine(arr, sb, padding);
            foreach (string item in arr)
            {
                AddEmptyPadding(sb, padding, arr);
                sb.AppendLine(AddPaddingToItem(arr,padding,item));
                AddEmptyPadding(sb, padding, arr);
            }
            InsertHeadandFooterLine(arr, sb, padding);
            return sb.ToString();
        }

        public static void InsertHeadandFooterLine(string[] arr, StringBuilder sb, int padding)
        {
            int Length = ReturnLongestStringLengthInArray(arr) + (padding*2);
            sb.AppendLine(BuildHeaderFooterLine(Length));
        }

        public static void AddEmptyPadding(StringBuilder sb, int padding, string[] arr)
        {
            int compter = 0;
            int Length = ReturnLongestStringLengthInArray(arr);
            while (compter < padding)
            {
                compter++;
                sb.AppendLine(BuildPaddingLine(Length));
            }   
        }

        public static string AddPaddingToItem(string [] arr ,int padding, string item)
        {
            int Length = ReturnLongestStringLengthInArray(arr);


            if (padding == 0 && item.Length < Length)
            {
                return SymbolAlongVerticalBorder + item + new string(SymbolForEmptySpace, Length - item.Length) + SymbolAlongVerticalBorder;
            }
            else if (padding == 0 && item.Length == Length)
            {
                return SymbolAlongVerticalBorder + item + SymbolAlongVerticalBorder;
            }
            else if (padding != 0)
            { 
                return SymbolAlongVerticalBorder+ new string(SymbolForEmptySpace, padding) + item + new string(SymbolForEmptySpace, padding) + SymbolAlongVerticalBorder;
            }

            return "";
        }

        public static int ReturnLongestStringLengthInArray(string[] arr)
        {
            var maxLength = int.MinValue;
            foreach (var item in arr)
            {
                if (item.Length > maxLength) maxLength = item.Length;
            }

            return maxLength;
        }

        public static string BuildHeaderFooterLine(int maxPrintWidth)
        {
            return $"{SymbolAtCorner}{new string(CharAlongHorizontalBorder, maxPrintWidth)}{SymbolAtCorner}";
        }

        public static string BuildPaddingLine(int maxPrintWidth)
        {
            return $"{SymbolAlongVerticalBorder}{SymbolForEmptySpace}{new string(SymbolForEmptySpace, maxPrintWidth)}{SymbolForEmptySpace}{SymbolAlongVerticalBorder}";
        }

        public static string[] Compare(string message)
        {
            string Lower = "\r\n";
            string newMessage;
            bool check = message.Contains(Lower);
            if (check == true) { newMessage = message.Replace(Lower, " "); return newMessage.Split(" "); }

            return message.Split(" ");
        }
    }
}
