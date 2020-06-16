using System;
using System.IO;

namespace BootCamp.Chapter.Examples.Decorator
{
    public class NotebookWithFile : INotebookWriter
    {
        private readonly INotebookWriter _notebook;
        private readonly string _file;

        public NotebookWithFile(INotebookWriter notebook, string file)
        {
            _notebook = notebook;
            _file = file;
        }

        public void Write(string note)
        {
            _notebook.Write(note);
            File.WriteAllText(_file ,$"{DateTime.Now} - {note}{Environment.NewLine}");
        }
    }
}
