using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    public class Person
    {
        public string Name { get; set; }
        public string BirthDay { get; set; }
        public string SureName { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string StreetAdress { get; set; }

        public int CalculateAge()
        {
            CultureInfo culture = new CultureInfo("en-US");
            var convertedBirthday = DateTime.Parse(this.BirthDay, culture).Year;
            var age = DateTime.Now.Year - convertedBirthday; 
            return age; 
        }
    }
}