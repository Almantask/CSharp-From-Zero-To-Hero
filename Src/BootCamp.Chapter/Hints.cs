using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Hints
{
	// Leave it empty, because subjects are unrelated. Just for simulation
	// Alternatively use base Subject class.
	public interface ISubject
	{
		Subject Subject { get; set; }
	}

	// For simulation you can store a specific teacher to school.
	// However for the interface based on requirements it is not needed.
	public interface ISchool<TStudent> where TStudent : IStudent
	{
		// Missing:
		// Add
		void AddStudent(TStudent student);

		// Get
		List<TStudent> Students { get; }
	}

	public interface IStudent
	{
		long Id { get; }

		void LearnFrom<TTeacher, TSubject>(TTeacher teacher)
			where TTeacher : ITeacher<TSubject>
			where TSubject : ISubject;
	}


	public interface ITeacher<TSubject> where TSubject : ISubject
	{
		TSubject ProduceMaterial();
	}
}
