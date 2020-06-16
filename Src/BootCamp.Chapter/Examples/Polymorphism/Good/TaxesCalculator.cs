using BootCamp.Chapter.Examples.Polymorphism.BadTypes;

namespace BootCamp.Chapter.Examples.Polymorphism.Good
{
    public static class TaxesCalculator3
    {
        public static decimal Calculate(ITaxes taxes, decimal money)
        {
            return taxes.DoComplexCalculation(money);
        }
    }
}
