namespace BootCamp.Chapter.Examples.Polymorphism.BadProps
{
    public static class TaxesCalculator1
    {
        public static decimal Calculate(Taxes taxes, decimal money)
        {
            if (taxes.Type == TaxType.Tax1)
            {
                return ComplexCalculation1(money, taxes.Value);
            }
            if (taxes.Type == TaxType.Tax2)
            {
                return ComplexCalculation2(money, taxes.Value);
            }
            if (taxes.Type == TaxType.Tax3)
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
