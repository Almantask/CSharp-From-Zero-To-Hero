using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public class ReqOne
    {
        public int Hours { get; set; }
        public IEnumerable<decimal> Price { get; set; }

        public ReqOne(int getItemCountByHour, IEnumerable<decimal> getTotalPriceByHour)
        {
            Hours = getItemCountByHour;
            Price = getTotalPriceByHour;
        }
    }
}
