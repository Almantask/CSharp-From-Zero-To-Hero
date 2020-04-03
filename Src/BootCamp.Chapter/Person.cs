using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public string SureName { get; set; }
        public Gender Gender { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string StreetAdress { get; set; }
        public int Age { get => CalculateAge(); } 

        public int CalculateAge()
        {
            int age = 0;
            age = DateTime.Now.Year - BirthDay.Year;
            if (DateTime.Now.DayOfYear < BirthDay.DayOfYear)
                age = age - 1;

            return age;
        }


    }
}