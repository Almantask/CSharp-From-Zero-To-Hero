using BootCamp.Chapter.Teachers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Students
{
	public class HighSchoolStudent : Student
	{
		public void LearnFrom(HighSchoolTeacher teacher)
		{
			base.LearnFrom<HighSchoolTeacher>(teacher);
		}
	}
}
