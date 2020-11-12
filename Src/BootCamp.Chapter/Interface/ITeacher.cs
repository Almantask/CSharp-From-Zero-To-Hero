using System;

namespace BootCamp.Chapter.Interface
{
    public interface ITeacher<out TSubject> where TSubject : ISubject
    {
        TSubject ProduceMaterial();
    }
}
