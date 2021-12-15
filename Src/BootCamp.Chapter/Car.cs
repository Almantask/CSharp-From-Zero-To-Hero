using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    // This should have the following attribute
    // [Textable]
    [Textable]
    public class Car
    {
        public string Brand { get; }
        public string Name { get; }

        public Car(string brand, string name)
        {
            Brand = brand;
            Name = name;
            var print = AttributesGetter.GetClassAttribute<TextableAttribute>(GetType());
        }

        // Do not change the bellow
        public override string ToString() => $"{Brand} {Name}";
    }
}
