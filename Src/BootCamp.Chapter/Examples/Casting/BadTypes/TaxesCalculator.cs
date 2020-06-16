namespace BootCamp.Chapter.Examples.Polymorphism.BadTypes
{
    public static class TaxesCalculator2
    {
        public static decimal Calculate(Examples.Taxes taxes, decimal money)
        {
            var type = taxes.GetType();

            if (type == typeof(Taxes1))
            {
                return ComplexCalculation1(money, taxes.Value);
            }
            if (type == typeof(Taxes2))
            {
                return ComplexCalculation2(money, taxes.Value);
            }
            if (type == typeof(Taxes3))
            {
                return ComplexCalculation3(money, taxes.Value);
            }
            else
            {
                return money;
            }
        }

        private static decimal ComplexCalculation3(in decimal money, in decimal taxesValue)
        {
            throw new System.NotImplementedException();
        }

        private static decimal ComplexCalculation2(in decimal money, in decimal taxesValue)
        {
            throw new System.NotImplementedException();
        }

        private static decimal ComplexCalculation1(in decimal money, in decimal taxesValue)
        {
            throw new System.NotImplementedException();
        }
    }
}
