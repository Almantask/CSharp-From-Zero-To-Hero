namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            RunApplication();
        }

        static void RunApplication()
        {
            Application app = new Application(@"C:\Projects\C#\Files\BootCampCredentialFiles\File.txt");
            app.Run();
        }
    }
}
