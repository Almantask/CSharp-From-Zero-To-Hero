using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Student(string name)
        {
            Name = name;
        }

        public Student(string name, int id) : this(name)
        {
            Id = id;
        }
    }
}
