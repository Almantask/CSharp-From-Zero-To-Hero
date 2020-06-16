using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.Decorator
{
    public class Notebook : INotebookWriter
    {
        public string Content { get; set; } = "";

        public virtual void Write(string note)
        {
            Console.WriteLine(note);
        }
    }
}
