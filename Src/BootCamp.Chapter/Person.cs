using System.Collections.Generic;
using System;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace BootCamp.Chapter
{
	public class Person
	{
		// add missing properties
		public string Name { get; set; }
		public string LastName { get; set; }
		public DateTime BirthDate { get; set; }
		public Gender Gender { get; set; }
		public string Country { get; set; }
		public string Email { get; set; }
		public string StreetAddress { get; set; }

		public bool IsOver18 => (DateTime.Now.Year - BirthDate.Year) > 18;
		public bool IsLivingInUK => Country == "UK";
		public bool HasAInName => Name.ToLower().Contains('a');
		public bool HasAInLastName => LastName.ToLower().Contains('a');

		public static List<Person> ConvertFromFile(string filename)
		{
			if (string.IsNullOrEmpty(filename) || !File.Exists(filename)) throw new FileNotFoundException();

			//Read the file
			List<string[]> peopleProperties = new List<string[]>();
			using (TextFieldParser parser = new TextFieldParser(filename))
			{
				if (parser.EndOfData) throw new Exception("File is empty");
				//Set delimiter
				parser.Delimiters = new string[] { "," };
				//Skip the first line as it's just property names
				parser.ReadLine();
				//Parse the remaining lines
				while (!parser.EndOfData)
				{
					peopleProperties.Add(parser.ReadFields());
				}
			}

			//Convert to Person objects
			List<Person> people = new List<Person>();
			foreach (string[] personProperties in peopleProperties)
			{
				if (personProperties.Length != 7) throw new Exception($"Line ({personProperties}) does not have all the properties needed to make a Person object.");
				people.Add(new Person()
				{
					Name = personProperties[0],
					LastName = personProperties[1],
					BirthDate = DateTime.Parse(personProperties[2]),
					Gender = Enum.Parse<Gender>(personProperties[3]),
					Country = personProperties[4],
					Email = personProperties[5],
					StreetAddress = personProperties[6]
				});
			}

			return people;
		}
	}

	public enum Gender
	{
		Male,
		Female
	}
}