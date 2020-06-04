using BootCamp.Chapter.Subjects;
using BootCamp.Chapter.Teachers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Students
{
    public class Student : IStudent
    {
        public string Name { get; }

        public Guid guid { get; } = new Guid();

        public Student(string name)
        {
            Name = name;
        }

        public void LearnFrom<TTeacher, TSubject>(TTeacher teacher)
            where TTeacher : ITeacher<TSubject>
            where TSubject : ISubject
        {
            ISubject material = teacher.ProduceMaterial();

            Console.WriteLine($"Learning {material.Title} from teacher of type {nameof(teacher)}");
        }
    }
}
