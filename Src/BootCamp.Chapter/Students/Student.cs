using BootCamp.Chapter.Hints;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Students
{
	public class Student : IStudent
	{
		private static long IdCount = 0;
		public long Id { get; set; } = IdCount++;
		public List<ISubject> LearnedSubjects { get; set; } = new List<ISubject>();

		public Student()
		{
		}
		public void LearnFrom<TTeacher>(TTeacher teacher) where TTeacher : ITeacher<TeachingSubject>
		{
			LearnFrom<TTeacher, TeachingSubject>(teacher);
		}
		public void LearnFrom<TTeacher, TSubject>(TTeacher teacher)
			where TTeacher : ITeacher<TSubject>
			where TSubject : ISubject
		{
			ISubject subject = teacher.ProduceMaterial() ?? throw new NullReferenceException();
			LearnedSubjects.Add(subject);
			Console.WriteLine($"{this.GetType().Name} learned {subject.Subject} from {teacher.GetType().Name}.");
		}

	}
}
