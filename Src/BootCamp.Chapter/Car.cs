using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    // This should have the following attribute
    // [Textable]
    [Textable(4, "-", "|", "+")]
    public class Car
    {
        public string Brand { get; }
        public string Name { get; }

        public Car(string brand, string name)
        {
            Brand = brand;
            Name = name;
            var print = AttributesGetter.GetClassAttribute<TextableAttribute>(GetType());
            //if (print != null)
            //{
            //    //Console.WriteLine(print.Padding);
            //    //Console.WriteLine(print.SideLeft);
            //    //Console.WriteLine(print.SideTop);
            //    //Console.WriteLine(print.Corner);
            //    TextBoxPrinter.Print(this);
            //}
        }

        // Do not change the bellow
        public override string ToString() => $"{Brand} {Name}";
    }
}
