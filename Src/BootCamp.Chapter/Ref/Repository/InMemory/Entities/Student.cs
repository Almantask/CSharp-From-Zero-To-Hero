using System.Collections.Generic;

namespace BootCamp.Chapter.Ref.Repository.InMemory.Entities
{
    public class Student: Person
    {
        public List<Grade> Grades { get; set; }
    }
}
