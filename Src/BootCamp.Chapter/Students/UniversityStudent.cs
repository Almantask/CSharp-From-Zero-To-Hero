using BootCamp.Chapter.Interface;
using System;

namespace BootCamp.Chapter.Students
{
    class UniversityStudent : IStudent
    {
        public long Id { get; }
        public static int counter = 0;

        public UniversityStudent()
        {
            counter++;
            Id = counter;
        }

        public void LearnFrom<TTeacher, TSubject>(TTeacher teacher)
            where TTeacher : ITeacher<TSubject>
            where TSubject : ISubject
        {
            Console.WriteLine($"Universitystudent number {Id} is learning from {teacher}");
        }
    }
}
