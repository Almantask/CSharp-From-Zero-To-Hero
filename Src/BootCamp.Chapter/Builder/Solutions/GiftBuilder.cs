using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootCamp.Chapter.Builder.Problems;

namespace BootCamp.Chapter.Builder.Solutions
{
    public class GiftBuilder
    {
        public Gift Gift;

        public GiftBuilder(Gift gift)
        {
            Gift = gift;
        }

        public GiftBuilder()
        {
            Gift = new Gift();
        }

        public GiftBuilder AddItem(string item)
        {
            Gift.Content += "Item: " + item;

            return this;
        }

        public GiftBuilder AddRibbon(Color color)
        {
            Gift.Content += color.ToString() + " ribbon";

            return this;
        }

        public GiftBuilder AddPackaging(Color color)
        {
            Gift.Content += color.ToString() + " packaging";

            return this;
        }
    }
}
