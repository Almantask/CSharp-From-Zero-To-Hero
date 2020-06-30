using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    interface ITeacher
    {
        public interface ITeacher<TSubject> where TSubject : ISubject
        {
            TSubject ProduceMaterial();
        }
    }
}
