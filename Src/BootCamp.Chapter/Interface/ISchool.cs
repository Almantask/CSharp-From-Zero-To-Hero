using System;

namespace BootCamp.Chapter.Interface
{
    public interface ISchool<TStudent> where TStudent : IStudent
    {
        void AddTeacher(ITeacher<ISubject> subject);
        ITeacher<ISubject> GetTeacher(ISubject subject);
    }
}
