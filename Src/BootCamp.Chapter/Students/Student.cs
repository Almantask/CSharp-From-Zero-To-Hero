using System;
using BootCamp.Chapter.Subjects;
using BootCamp.Chapter.Teachers;

namespace BootCamp.Chapter.Students
{
    public abstract class Student : IStudent
    {
        public string Name { get; }
        public Guid Id { get; } = new Guid();

        public Student(string name)
        {
            Name = name;
        }
        
        public void LearnFrom<TTeacher, TSubject>(TTeacher teacher)
            where TTeacher : ITeacher<TSubject>
            where TSubject : ISubject
        {
            var material = teacher.ProduceMaterial();
            
            Console.WriteLine($"{Name}: Learning \"{material.Content}\" from \"{material.Title}\"");
        }
    }
}