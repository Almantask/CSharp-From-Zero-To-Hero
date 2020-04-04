﻿using BootCamp.Chapter.Students;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Schools
{
    interface ISchool<TStudent> where TStudent : IStudent
    {
        public void Add(TStudent student);
        //TODO. school has list of students and teachers.
        
        // Missing:
        // Add
        // Get
    }
}
