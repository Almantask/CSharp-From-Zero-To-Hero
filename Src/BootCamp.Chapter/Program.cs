using BootCamp.Chapter.Hints;
using BootCamp.Chapter.Students;
using BootCamp.Chapter.Teachers;
using BootCamp.Chapter.Schools;
using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
	class Program
	{
		static void Main(string[] args)
		{
			//Create teacher
			UniversityTeacher teacher = new UniversityTeacher(new TeachingSubject(Subject.Programming));
			teacher.ProduceMaterial();

			Console.WriteLine();

			//Create student
			UniversityStudent student = new UniversityStudent();
			student.LearnFrom(teacher);

			Console.WriteLine();

			//Create school
			University school = new University();
			school.AddStudent(student);
			List<UniversityStudent> students = school.Students;
			Console.WriteLine($"{students.Count} {students.GetType().GetGenericArguments()[0].Name}(s) in {school.GetType().Name}.");

			Console.ReadLine();
		}
	}
}
