using System.Collections.Generic;

namespace BootCamp.Chapter.Ref.Models
{
    public class Student: Person
    {
        public List<Grade> Grades { get; set; }
    }
}
