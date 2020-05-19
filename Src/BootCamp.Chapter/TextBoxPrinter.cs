using System.Text;

namespace BootCamp.Chapter
{
    public static class TextBoxPrinter
    {
        public static string Print(object obj)
        {
            var textTableAttribute = AttributesGetter.GetClassAttribute<TextTableAttribute>(obj.GetType());
            if (textTableAttribute == null) return obj.ToString();
            
            return BuildTable(textTableAttribute, obj.ToString());
        }

        private static string BuildTable(TextTableAttribute textTable, string message)
        {
            var table = new StringBuilder();
            var paddingSpaceLength = textTable.Padding * 2;
            var maxTableLines = 3 + paddingSpaceLength;
            
            var topAndBottom = textTable.Corner +
                               new string(textTable.SideTop, message.Length + paddingSpaceLength) + 
                               textTable.Corner;
            var mainLine = textTable.SideLeft + new string(' ', textTable.Padding) +
                           message.PadLeft(textTable.Padding).PadRight(textTable.Padding) +
                           new string(' ', textTable.Padding) + textTable.SideLeft;
            var paddingLine = textTable.SideLeft +
                               new string(' ', message.Length + paddingSpaceLength) + 
                               textTable.SideLeft;

            for (var i = 0; i < maxTableLines; i++)
            {
                if (i == 0 || i == maxTableLines - 1)
                {
                    table.AppendLine(topAndBottom);
                    continue;
                }

                table.AppendLine(i == maxTableLines / 2 ? mainLine : paddingLine);
            }
            
            return table.ToString().TrimEnd();
        }
    }
}
