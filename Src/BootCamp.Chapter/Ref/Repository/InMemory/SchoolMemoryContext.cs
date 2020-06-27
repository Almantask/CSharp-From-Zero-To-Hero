using System;
using System.Collections.Generic;
using BootCamp.Chapter.Ref.Enums;
using BootCamp.Chapter.Ref.Repository.InMemory.Entities;

namespace BootCamp.Chapter.Ref.Repository.InMemory
{
    public class SchoolMemoryContext : ISchoolMemoryContext
    {
        public virtual List<Student> Students { get; set; }
        public virtual List<Teacher> Teachers { get; set; }
        public virtual List<Grade> Grades { get; set; }
        public virtual List<LessonClass> Lessons { get; set; }

        public SchoolMemoryContext()
        {
            Students = new List<Student>()
            {
                new Student()
                {
                    Age = 14,
                    Grades = new List<Grade>
                    {
                        Maths(1, 1, GradeEvaluation.Acceptable),
                        Chemistry(1, 2, GradeEvaluation.Failed),
                        Chemistry(1, 3, GradeEvaluation.Good)
                    },
                    Id = 1,
                    Name = "Thomas",
                    Surename = "Jenkins"
                },
                new Student()
                {
                    Age = 15,
                    Grades = new List<Grade>
                    {
                        Maths(2, 4, GradeEvaluation.Acceptable),
                        Chemistry(2, 5, GradeEvaluation.Failed),
                        Chemistry(2, 6, GradeEvaluation.Good)
                    },
                    Id = 2,
                    Name = "Tina",
                    Surename = "Jenkins"
                }
            };

            Lessons = new List<LessonClass>
            {
                new LessonClass()
                {
                    Description = "Experimental",
                    Id = 1,
                    Name = "Chemistry 1",
                    Students = Students,
                    Subject = LessonSubject.Chemistry,
                    TeacherId = 1
                }
            };

            Teachers = new List<Teacher>
            {
                new Teacher
                {
                    Age = 30,
                    Id = 1,
                    Name = "Diana",
                    Surename = "Watson",
                    LessonClass = Lessons[0],
                    LessonClassId = 1,
                    PhoneNumber = "+3706 3548797"
                }
            };

            Grades = new List<Grade>
            {
                Maths(1, 1, GradeEvaluation.Acceptable),
                Chemistry(1, 2, GradeEvaluation.Failed),
                Chemistry(1, 3, GradeEvaluation.Good),
                Maths(2, 4, GradeEvaluation.Acceptable),
                Chemistry(2, 5, GradeEvaluation.Failed),
                Chemistry(2, 6, GradeEvaluation.Good)
            };
        }

        private Grade Maths(uint studentId, uint gradeId, GradeEvaluation evaluation)
        {
            return
                new Grade()
                {
                    DateTime = DateTime.Now,
                    Evaluation = evaluation,
                    Id = gradeId,
                    StudentId = studentId,
                    Notes = "Good Boy",
                    Subject = LessonSubject.Maths
                };
        }

        private Grade Chemistry(uint studentId, uint gradeId, GradeEvaluation evaluation)
        {
            return
                new Grade()
                {
                    DateTime = DateTime.Now,
                    Evaluation = evaluation,
                    Id = gradeId,
                    StudentId = studentId,
                    Notes = "Good Boy",
                    Subject = LessonSubject.Chemistry
                };
        }

        private Grade English(uint studentId, uint gradeId, GradeEvaluation evaluation)
        {
            return
                new Grade()
                {
                    DateTime = DateTime.Now,
                    Evaluation = evaluation,
                    Id = gradeId,
                    StudentId = studentId,
                    Notes = "Good Boy",
                    Subject = LessonSubject.English
                };
        }
    }
}
