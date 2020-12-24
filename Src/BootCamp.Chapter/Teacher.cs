using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Hints;

namespace BootCamp.Chapter
{
    class Teacher<TSubject>: ITeacher<TSubject> where TSubject : ISubject
    {
       public TSubject ProduceMaterial()
       {
            Console.WriteLine($"Welcome to {TSubject}lesson");
            return TSubject;

       }
    }
}
