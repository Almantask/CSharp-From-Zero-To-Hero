using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Hints;

namespace BootCamp.Chapter
{
    class Student:IStudent
    {
        public long Id { get; }
        public Student(long id)
        {
            Id = id;
        }
        public void LearnFrom<TTeacher, TSubject>( TTeacher teacher)
                    where TTeacher : Teacher<TSubject>
                    where TSubject : Subject, new()
        {
            Console.WriteLine($"student {Id} learn from {teacher.Name} teacher");
        }
    }
    class UniversityStudent:Student
    {
        public UniversityStudent(long id) : base(id)
        { }
    }
    class HighSchoolStudent:Student
    {
        public HighSchoolStudent(long id):base(id)
        { }
    }
}
