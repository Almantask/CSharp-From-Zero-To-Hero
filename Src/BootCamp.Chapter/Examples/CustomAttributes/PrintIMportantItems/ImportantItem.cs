using System;

namespace BootCamp.Chapter.Examples.CustomAttributes.PrintIMportantItems
{
    public class ImportantItem
    {
        public ImportantItem()
        {
            var print = AttributesGetter.GetClassAttribute<PrintAttribute>(GetType());
            if (print != null)
            {
                Console.WriteLine(print.Message);
            }
        }
    }
}
