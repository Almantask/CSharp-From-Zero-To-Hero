namespace BootCamp.Chapter.Examples.Decorator
{
    public sealed class NotebookWithDatabase : INotebookWriter
    {
        private readonly INotebookWriter _notebook;
        private readonly INotebookRepository _repo;
        private readonly long _notebookId;

        public NotebookWithDatabase(INotebookWriter notebook, long notebookId)
        {
            _notebook = notebook;
            // This example is not the best for a db.
            // It would be more complex than this.+
            _repo = null;
            _notebookId = notebookId;
        }

        public void Write(string note)
        {
            _notebook.Write(note);
            _repo.Save(note, _notebookId);
        }
    }

    public interface INotebookRepository
    {
        void Save(string note, in long notebookId);
    }
}
