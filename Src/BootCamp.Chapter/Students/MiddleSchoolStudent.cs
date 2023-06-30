using BootCamp.Chapter.Teachers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Students
{
	public class MiddleSchoolStudent : Student
	{
		public void LearnFrom(MiddleSchoolTeacher teacher)
		{
			base.LearnFrom<MiddleSchoolTeacher>(teacher);
		}
	}
}
