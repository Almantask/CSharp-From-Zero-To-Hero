using System.Drawing;

namespace BootCamp.Chapter.Builder.Problems
{
    class RepeatingArg
    {
        public static void Demo()
        {
            var gift = new Gift();
            AddItem(gift, "Test");
            AddRibbon(gift, Color.AliceBlue);
            AddPackaging(gift, Color.Azure);
        }

        private static void AddItem(Gift gift, string item)
        {
            gift.Content += "Item: " + item;
        }

        private static void AddRibbon(Gift gift, Color color)
        {
            gift.Content +=  color.ToString() + " ribbon";
        }

        private static void AddPackaging(Gift gift, Color color)
        {
            gift.Content += color.ToString() + " packaging";
        }
    }
}
