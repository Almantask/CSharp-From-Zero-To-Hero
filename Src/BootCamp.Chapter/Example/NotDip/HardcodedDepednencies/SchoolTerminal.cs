using System;
using System.Collections.Generic;
using BootCamp.Chapter.Ref;
using BootCamp.Chapter.Ref.Repository.File.Repository;
using BootCamp.Chapter.Ref.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BootCamp.Chapter.Example.NotDip
{
    public class SchoolTerminal : ISchoolTerminal
    {
        private readonly IStudentsRepository _studentsRepository;
        private readonly ITeachersRepository _teachersRepository;
        private readonly IGradesRepository _gradesRepository;
        private readonly ILessonClassesRepository _lessonClassesRepository;

        public SchoolTerminal()
        {
            _studentsRepository = new StudentsRepository();
            _teachersRepository = new TeachersRepository();
            _gradesRepository = new GradesRepository();
            _lessonClassesRepository = new LessonClassesRepository();
        }

        public void Start()
        {
            var students = _studentsRepository.Get();
            var teachers = _teachersRepository.Get();
            var grades = _gradesRepository.Get();
            var lessonClasses = _lessonClassesRepository.Get();

            Console.WriteLine("Students:");
            PrintEntities(students);

            Console.WriteLine("Teachers:");
            PrintEntities(teachers);

            Console.WriteLine("Grades:");
            PrintEntities(grades);

            Console.WriteLine("Classes:");
            PrintEntities(lessonClasses);
        }

        private void PrintEntities<T>(IEnumerable<T> entities)
        {
            const string lineSeparator = "----------------";
            Console.WriteLine(lineSeparator);
            var index = 1;
            foreach (var entity in entities)
            {
                Console.WriteLine($"{index}) {entity}");
                index++;
            }
            Console.WriteLine(lineSeparator);
            Console.WriteLine();
        }
    }
}
