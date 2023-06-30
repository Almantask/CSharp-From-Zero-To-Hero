using BootCamp.Chapter.Teachers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Students
{
	public class UniversityStudent : Student
	{
		public void LearnFrom(UniversityTeacher teacher)
		{
			base.LearnFrom<UniversityTeacher>(teacher);
		}
	}
}
