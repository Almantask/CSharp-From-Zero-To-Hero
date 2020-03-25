using BootCamp.Chapter.StudentInfo;
using BootCamp.Chapter.Subjects;
using BootCamp.Chapter.Teachers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.SchoolInfo
{
    class University : ISchool<IStudent<ITeacher<Subject>>, TId> where IStudent : UniversityStudent
                                                                          where ITeacher : UniversityTeacher
    {
        public void Add(IStudent<ITeacher<Subject>> student)
        {
            throw new NotImplementedException();
        }

        public IStudent<ITeacher<Subject>> Get(TId id)
        {
            throw new NotImplementedException();
        }

        public IList<IStudent<ITeacher<Subject>>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
