using System;
using System.Collections.Generic;
using BootCamp.Chapter.Ref.Repository.Interfaces;

namespace BootCamp.Chapter.Ref.Application
{
    public class SchoolTerminal : ISchoolTerminal
    {
        private readonly IStudentsRepository _studentsRepository;
        private readonly ITeachersRepository _teachersRepository;
        private readonly IGradesRepository _gradesRepository;
        private readonly ILessonClassesRepository _lessonClassesRepository;

        public SchoolTerminal(
            IStudentsRepository studentsRepository,
            ITeachersRepository teachersRepository,
            IGradesRepository gradesRepository,
            ILessonClassesRepository lessonClassesRepository)
        {
            _studentsRepository = studentsRepository;
            _teachersRepository = teachersRepository;
            _gradesRepository = gradesRepository;
            _lessonClassesRepository = lessonClassesRepository;
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
