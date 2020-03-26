using BootCamp.Chapter.StudentInfo;
using BootCamp.Chapter.Teachers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.SchoolInfo
{
    interface ISchool<TStudent, TId>
    {
        TStudent Get(TId id);
        IList<TStudent> Get();
        void Add(TStudent student);
        public List<TStudent> students { get; set; }

    }
}
