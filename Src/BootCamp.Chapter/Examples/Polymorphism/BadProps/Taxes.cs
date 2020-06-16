using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples
{
    public enum TaxType
    {
        Tax1,
        Tax2,
        Tax3
    }

    public class Taxes
    {
        public TaxType Type { get; set; }
        public decimal Value { get; set; }
    }
}
