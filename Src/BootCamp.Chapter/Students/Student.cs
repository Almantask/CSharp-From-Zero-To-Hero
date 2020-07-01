using BootCamp.Chapter.Teachers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Students
{
    class Student : IStudent
    {
        public string Name { get; }
        public Guid @Guid { get; }
        public Student(string name)
        {
            Name = name;
            @Guid = new Guid();
        }

        public void LearnFrom<TTeacher, TSubject>(TTeacher teacher)
                where TTeacher : ITeacher<TSubject>
                where TSubject : ISubject
        {
            ISubject learningMaterial = teacher.ProduceTeachingMaterial();
            Console.WriteLine($"{Name} is learning {learningMaterial.Name} from {teacher.Name} who teaches {teacher.SubjectTaught}!");
        }

    }
}
