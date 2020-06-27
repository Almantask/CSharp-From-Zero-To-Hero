using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Ref;
using BootCamp.Chapter.Ref.Application;
using BootCamp.Chapter.Ref.Repository.InMemory;
using BootCamp.Chapter.Ref.Repository.InMemory.Repositories;

namespace BootCamp.Chapter.Example.DIP.NoIoc
{
    class SchoolTerminalDemo
    {
        public static void Run()
        {
            var context = new SchoolMemoryContext();

            ISchoolTerminal app = new SchoolTerminal(
                new StudentsRepository(context),
                new TeachersRepository(context),
                new GradesRepository(context),
                new LessonClassesRepository(context));
        }
    }
}
