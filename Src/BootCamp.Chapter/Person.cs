using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Person
    {
        public Person(string firstName, string lastName, int age, float weight, float heigth)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _weight = weight;
            _heigth = heigth;
        }

        private string _firstName;

        public string GetFirstName()
        {
            return _firstName;
        }

        public void SetFirstName(string firstName)
        {
            _firstName = firstName;
        }

        private string _lastName;

        public string GetLastName()
        {
            return _lastName;
        }

        public void SetLastName(string lastName)
        {
            _lastName = lastName;
        }

        private int _age;

        public int GetAge()
        {
            return _age;
        }

        public void SetAge(int age)
        {
            _age = age;
        }

        private float _weight;

        public float GetWeight()
        {
            return _weight;
        }

        public void SetWeight(float weight)
        {
            _weight = weight;
        }

        private float _heigth;

        public float GetHeigth()
        {
            return _heigth;
        }

        public void SetHeigth(float heigth)
        {
            _heigth = heigth;
        }
    }
}