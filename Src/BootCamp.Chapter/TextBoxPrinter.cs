namespace BootCamp.Chapter
{
    public static class TextBoxPrinter
    {
        public static string Print(object obj)
        {
            var getTextTableAttribute = AttributesGetter.GetClassAttribute<TextTableAttribute>(obj.GetType());
            if (getTextTableAttribute == null) return obj.ToString();

            TextBoxBuilder textBoxBuilder = new TextBoxBuilder(getTextTableAttribute, obj.ToString());

            return textBoxBuilder.BuildTextBox();
        }
    }
}
