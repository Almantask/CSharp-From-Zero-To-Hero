using System;
using System.Collections.Generic;
using System.Text;
    
namespace BootCamp.Chapter.Examples.Polymorphism.Good
{
    public interface ITaxes
    {
        decimal Amount { get; }
        decimal DoComplexCalculation(decimal money);
    }

    public class Tax1 : ITaxes
    {
        public decimal Amount { get; }
        public decimal DoComplexCalculation(decimal money)
        {
            // calc 1
            return money;
        }
    }

    public class Tax2 : ITaxes
    {
        public decimal Amount { get; }
        public decimal DoComplexCalculation(decimal money)
        {
            // calc 1
            return money;
        }
    }

    public class Tax3 : ITaxes
    {
        public decimal Amount { get; }
        public decimal DoComplexCalculation(decimal money)
        {
            // calc 1
            return money;
        }
    }
}
