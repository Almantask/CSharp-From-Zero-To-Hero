using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Text;

namespace BootCamp.Chapter
{
    public static class TextBoxPrinter
    {
        public static string Print(object obj)
        {
            var getTextTableAttribute = AttributesGetter.GetClassAttribute<TextTableAttribute>(obj.GetType());
            if (getTextTableAttribute == null) return obj.ToString();

            var table = GenerateTable(getTextTableAttribute, obj.ToString());
            Console.WriteLine(table);

            return GenerateTable(getTextTableAttribute, obj.ToString());
        }

        private static string GenerateTable(TextTableAttribute textTableAttributes, string message)
        {
            int messageLength = message.Length + (textTableAttributes.Padding * 2);
            int numberOfLines = 3 + (textTableAttributes.Padding * 2);
            int numberOfMainLine = (numberOfLines + 1) / 2;
            string paddingString = new string(' ', textTableAttributes.Padding);
            StringBuilder sb = new StringBuilder();

            string topAndBottom =
                $"{textTableAttributes.Corner}{new String(textTableAttributes.Horizontal, messageLength)}{textTableAttributes.Corner}";
            string mainLine = $"{textTableAttributes.Vertical}{message}{textTableAttributes.Vertical}";
            string mainLineWithPadding = $"{textTableAttributes.Vertical}{paddingString}{message}{paddingString}{textTableAttributes.Vertical}";
            string paddingLine =
                $"{textTableAttributes.Vertical}{new string(' ', messageLength)}{textTableAttributes.Vertical}";

            for (int i = 1; i < numberOfLines+1; i++)
            {
                if (i == 1 || i == numberOfLines)
                {
                    sb.AppendLine(topAndBottom);
                }
                else if (i != numberOfMainLine && textTableAttributes.Padding != 0)
                {
                    sb.AppendLine(paddingLine);
                }
                else if (i == numberOfMainLine && textTableAttributes.Padding == 0)
                {
                    sb.AppendLine(mainLine);
                }
                else if (i == numberOfMainLine && textTableAttributes.Padding != 0)
                {
                    sb.AppendLine(mainLineWithPadding);
                }
            }
            return sb.ToString().Trim();
        }
    }
}
