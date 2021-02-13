using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Decorator
{
    public class Problem
    {
        // imagine there are 3 behaviors: (A) Print text, (B) pick color, (C) authorize.
        // You need to do a mix of them: either A or B or C or AB or AC or BC or ABC.
        public class Printer
        {
            public virtual void Print(string text)
            {
                Console.WriteLine(text);
            }
        }

        public class PrinterWithColor : Printer
        {
            public virtual void Print(string text)
            {
                PickColor();
                base.Print(text);
            }

            private static void PickColor()
            {
                Console.WriteLine("Picking color");
            }
        }

        public class PrinterWithColorAndAuth : PrinterWithColor
        {
            public virtual void Print(string text)
            {
                Authorize();
                base.Print(text);
            }

            private static void Authorize()
            {
                Console.WriteLine("Authorizing");
            }
        }

        public static void Demo()
        {
            var printer = new PrinterWithColorAndAuth();
            printer.Print("Hello world");
        }

        // What if we want a basic printer, but with Auth?
        // - We would need to build a chain of components.
        // Inheritance could be one of the solutions, but there is another, better way.
    }
}
