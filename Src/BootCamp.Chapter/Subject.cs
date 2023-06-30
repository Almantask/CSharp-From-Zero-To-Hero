using BootCamp.Chapter.Hints;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
	public enum Subject
	{
		Math,
		Art,
		Music,
		PE,
		English,
		Programming
	}

	public struct TeachingSubject : ISubject
	{
		public Subject Subject { get; set; }

		public TeachingSubject(Subject subject)
		{
			Subject = subject;
		}
	}
}
