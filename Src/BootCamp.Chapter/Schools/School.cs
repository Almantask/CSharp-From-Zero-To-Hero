using BootCamp.Chapter.Hints;
using BootCamp.Chapter.Teachers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace BootCamp.Chapter.Schools
{
	public class School<TStudent> : ISchool<TStudent> where TStudent : IStudent
	{
		public List<TStudent> Students { get; set; } = new List<TStudent>();

		public void AddStudent(TStudent student)
		{
			Students.Add(student ?? throw new ArgumentNullException());
			Console.WriteLine($"{this.GetType().Name} added {student.GetType().Name}.");
		}
	}
}
