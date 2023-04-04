using System;
using BootCamp.Chapter.Hints;

namespace BootCamp.Chapter.Students
{
    public class MiddleSchoolStudent : IStudent
    {
        public long Id { get; }

        public MiddleSchoolStudent(long id)
        {
            Id = id;
        }
        
        public void LearnFrom<TTeacher, TSubject>(TTeacher teacher) where TTeacher : ITeacher<TSubject> where TSubject : ISubject
        {
            Console.WriteLine($"{nameof(MiddleSchoolStudent)} learning from {teacher.ToString()}");
        }
    }
}