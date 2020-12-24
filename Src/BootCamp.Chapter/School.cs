using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Hints;

namespace BootCamp.Chapter
{
     class School<TStudent> : ISchool<TStudent> where TStudent : IStudent
     {
        private readonly List<TStudent> _students;
        public List<TStudent> Student => _students;
        public School(List<TStudent>students)
        {
            this._students = students;
        }
            
        public void Add(TStudent student)
        {
            if(student!= null)
            {
                foreach(var item in _students)
                {
                    if (item.Id == student.Id)
                        return;    
                }
                _students.Add(student);
            }
            return;
        }
        public TStudent Get(long id)
        {
            foreach(var item in _students)
            {
                if (item.Id == id)
                    return item;
            }
            return default;
        }
     }
     class UniversitySchool : School<UniversityStudent>
     {
        public UniversitySchool(List<UniversityStudent> students) : base(students)
        { }
     }
     class HighSchool : School<HighSchoolStudent>
     {
        public HighSchool(List<HighSchoolStudent> students) : base(students)
        { }
     }
}
