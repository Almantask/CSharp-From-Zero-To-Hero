using System;

namespace BootCamp.Chapter.Examples.Decorator
{
    public class NotebookWithEmailNotifications : INotebookWriter
    {
        private readonly INotebookWriter _notebook;
        private readonly string _email;

        public NotebookWithEmailNotifications(INotebookWriter notebook, string email)
        {
            _notebook = notebook;
            _email = email;
        }

        public void Write(string note)
        {
            _notebook.Write(note);
            SendEmail(_email, note);
        }

        private void SendEmail(string email, string message)
        {
            throw new NotImplementedException();
        }
    }
}
