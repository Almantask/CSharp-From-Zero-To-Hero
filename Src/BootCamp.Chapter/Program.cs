namespace BootCamp.Chapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var data = ParseFile.Parse();
            Statics.FindPostOfficeWithMostErrors(data);
        }
    }
}