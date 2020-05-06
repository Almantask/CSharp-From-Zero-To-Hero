namespace BootCamp.Chapter
{
    public static class TextBoxPrinter
    {
        public static string Print(object obj)
        {
            var properties = obj.GetType().GetProperties();
            var requiredAttributeTextable = new Textable();
            var requiredAtributeTextTable = new TextTable(0, 'a', 'b', 'c');

            foreach (var prop in properties)
            {
                requiredAttributeTextable = AttributesGetter.GetPropertyAttribute<Textable>(prop);
                requiredAtributeTextTable = AttributesGetter.GetPropertyAttribute<TextTable>(prop);
                if (requiredAttributeTextable == null && requiredAtributeTextTable == null) continue;
            }

            if (requiredAtributeTextTable != null)
            {
                return TablePrinter.DisplayTable(new TablePrinter(obj.ToString(), requiredAtributeTextTable.Padding, requiredAtributeTextTable.SideTop, requiredAtributeTextTable.SideLeft, requiredAtributeTextTable.Corner));
            }
            else if (requiredAttributeTextable != null)
            {
                return TablePrinter.DisplayTable(new TablePrinter(obj.ToString().Trim()));
            }

            return properties[0].GetValue(obj).ToString();
        }
    }
}