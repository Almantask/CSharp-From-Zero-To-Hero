using System;
using BootCamp.Chapter.Hints;

namespace BootCamp.Chapter.Students
{
    public class UniversityStudent : IStudent
    {
        public long Id { get; }

        public UniversityStudent(long id)
        {
            Id = id;
        }
        public void LearnFrom<TTeacher, TSubject>(TTeacher teacher) where TTeacher : ITeacher<TSubject> where TSubject : ISubject
        {
            Console.WriteLine($"{nameof(UniversityStudent)} {Id} learning from {teacher.ToString()}");
        }
    }
}