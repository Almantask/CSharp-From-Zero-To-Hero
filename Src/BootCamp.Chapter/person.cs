using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Person
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public double BMI
        {
            get
            {
                return Math.Round((Weight / (Height * Height)), 3);
            }
        }
        public DateTime Time { get; set; }


        public Person(string fullName, int age, double weight, double height, DateTime time)
        {
            this.FullName = fullName;
            this.Age = age;
            this.Weight = weight;
            this.Height = height;
            this.Time = time;
        }
    }
}