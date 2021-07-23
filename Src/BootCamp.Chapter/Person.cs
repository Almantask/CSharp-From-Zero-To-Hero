using System;

namespace BootCamp.Chapter
{
    class Person : IPerson
    {
        private string _firstName;
        private string _surName;
        private int _age;
        private float _weight;
        private float _height;

        public Person(string FirstName, string SurName, int Age, float Weight, float Height)
        {
            _firstName = FirstName;
            _surName = SurName;
            _age = Age;
            _weight = Weight;
            _height = Height;
        }

        public Person() : this("", "", 0, 0, 0) { }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string SurName { get => _surName; set => _surName = value; }
        public int Age { get => _age; set => _age = value; }
        public float Weight { get => _weight; set => _weight = value; }
        public float Height { get => _height; set => _height = value; }
        public float BMI { get => (float)Math.Round(CalculateBMI(_height, _weight), 2); }

        public void Introduce()
        {
            Console.WriteLine($"{_firstName} {_surName} is {_age} years old, his weight is {_weight} kg and his height is {_height} cm.");
        }

        private float CalculateBMI(float height, float weight) => (weight / height / height) * 703;
    }
}
