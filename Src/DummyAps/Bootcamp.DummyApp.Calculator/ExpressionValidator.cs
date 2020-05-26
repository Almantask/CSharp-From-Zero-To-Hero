namespace Bootcamp.DummyApp.Calculator
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
