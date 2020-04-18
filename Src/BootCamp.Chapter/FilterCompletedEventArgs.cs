using System.Linq;

namespace BootCamp.Chapter
{
    public class FilterCompletedEventArgs
    {
        public FilterCompletedEventArgs(IGrouping<string, Transaction> shop)
        {
            Shop = shop;
        }

        internal IGrouping<string, Transaction> Shop { get; }
    }
}
