using System;

namespace BootCamp.Chapter
{
    class Person
    {
        private string _name;
        private string _age;
        private string _weight;
        private string _height;


        public string Name {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            } 
        
        }

        public string Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }

        }

        public string Weight {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
            }
        }

        public string Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }

        }

        public Person(string name, string age, string weight, string height)
        {
            _name = name;
            _age = age;
            _weight = weight;
            _height = height;
        }

        public double BMIcalc()
        {
            var inMeters = double.Parse(_height) * 100;
            var metersSquared = Math.Pow(inMeters,2);
            var BMI = int.Parse(_weight) / metersSquared;

            return BMI;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var Person1 = new Person("Tom Jefferson", "19", "50", "156.5");
            var Person2 = new Person("Mike Miller", "28", "75", "160.2");

            var bmi1 = Person1.BMIcalc();
            var bmi2 = Person2.BMIcalc();


            Console.WriteLine($"{Person1.Name}'s BMI is {bmi1}");
            Console.WriteLine($"{Person2.Name}'s BMI is {bmi2}");
        }
    }



}

// BMI = kg/m2