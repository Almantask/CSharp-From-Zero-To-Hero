using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Subjects
{
    public abstract class SubjectBase : ISubject
    {
        public string Name { get; }

        protected SubjectBase(string name)
        {
            Name = name;
        }
    }
}
