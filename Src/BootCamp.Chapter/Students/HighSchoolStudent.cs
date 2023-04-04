using System;
using BootCamp.Chapter.Hints;

namespace BootCamp.Chapter.Students
{
    public class HighSchoolStudent : IStudent
    {
        public long Id { get; }

        public HighSchoolStudent(long id)
        {
            Id = id;
        }
        
        public void LearnFrom<TTeacher, TSubject>(TTeacher teacher) where TTeacher : ITeacher<TSubject> where TSubject : ISubject
        {
            Console.WriteLine($"{nameof(HighSchoolStudent)} learning from {teacher.ToString()}");
        }
    }
}