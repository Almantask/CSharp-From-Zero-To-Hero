using BootCamp.Chapter.StudentInfo;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Schools
{
    class School
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public List<Student<TId>> students; 
    }
}
