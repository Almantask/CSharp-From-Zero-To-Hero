namespace BootCamp.Chapter.Examples.Decorator
{
    public class DecoratorExample
    {
        public static void Demo()
        {
            var notebook = new Notebook()
                .WithEmailNotifications("example@google.com")
                .WithLogToDatabase(1)
                .WithLogToFile("C://Notebooks/Notebook1.txt");

            notebook.Write("Hello world");
        }
    }
}
