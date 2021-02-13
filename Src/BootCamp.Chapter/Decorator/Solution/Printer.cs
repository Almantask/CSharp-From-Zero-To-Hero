using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp.Chapter.Decorator.Solution
{
    public interface IPrinter
    {
        void Print(string text);
    }

    public class Printer : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }

    public class PrinterWithColor : IPrinter
    {
        // The thing which we decorate...
        private readonly IPrinter _printer;

        // ...We pass through constructor
        public PrinterWithColor(IPrinter printer)
        {
            _printer = printer;
        }

        public void Print(string text)
        {
            // Extra...
            PickColor();
            // ...And the same.
            _printer.Print(text);
        }

        private void PickColor()
        {
            Console.WriteLine("Picking a color");
        }
    }

    public class PrinterWithAuthorization : IPrinter
    {
        private readonly IPrinter _printer;

        public PrinterWithAuthorization(IPrinter printer)
        {
            _printer = printer;
        }

        public void Print(string text)
        {
            Authorize();
            _printer.Print(text);
        }

        private void Authorize()
        {
            Console.WriteLine("Authorizing");
        }
    }

}
