namespace BootCamp.Chapter.Examples.Decorator
{
    public static class NotebookWriterDecorators
    {
        public static INotebookWriter WithEmailNotifications(this INotebookWriter notebook, string email) 
            => new NotebookWithEmailNotifications(notebook, email);

        public static INotebookWriter WithLogToDatabase(this INotebookWriter notebook, long id)
            => new NotebookWithDatabase(notebook, id);
                    
        public static INotebookWriter WithLogToFile(this INotebookWriter notebook, string path)
            => new NotebookWithFile(notebook, path);
    }
}
