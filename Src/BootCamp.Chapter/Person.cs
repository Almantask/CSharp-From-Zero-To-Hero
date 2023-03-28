using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    internal class Person
    {
        string _name;
        public string GetName() { return _name; }
        float[] _balances;

        Person(string name, float[] balances)
        {
            _name = name;
            _balances = balances;
        }


    }
}
