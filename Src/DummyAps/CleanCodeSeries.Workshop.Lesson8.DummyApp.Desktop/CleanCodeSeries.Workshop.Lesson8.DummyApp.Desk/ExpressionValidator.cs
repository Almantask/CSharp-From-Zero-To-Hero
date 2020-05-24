using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeSeries.Workshop.Lesson8.DummyApp.Desk
{
    public static class ExpressionValidator
    {
        public static bool IsSpecialSymbol(char c)
        {
            return IsSpecialSymbol(c.ToString());
        }

        public static bool IsSpecialSymbol(string text)
        {
            return text == Calculator.Mul 
                || text == Calculator.Div 
                || text == Calculator.Sub
                || text == Calculator.Add;
        }
    }
}
