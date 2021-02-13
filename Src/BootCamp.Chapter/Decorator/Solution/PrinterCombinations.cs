using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp.Chapter.Decorator.Solution
{
    public static class PrinterCombinations
    {
        public static IPrinter WithColor(this IPrinter printer) => new PrinterWithColor(printer);
        public static IPrinter WithAuth(this IPrinter printer) => new PrinterWithAuthorization(printer);
    }
}
