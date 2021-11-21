using System;

namespace BootCamp.Chapter
{
    public static class MostCommonLetterFinder
    {
        public static char Find(string sentence)
        {
            if (sentence == "" || sentence == " " || sentence == null) throw new ArgumentNullException();

            int[] count = new int[256];
            int max = 0;
            Char result = Char.MinValue;

            Array.Clear(count, 0, count.Length - 1);

            foreach (Char c in sentence)
            {
                if (++count[c] > max)
                {
                    max = count[c];
                    result = c;
                }
            }

            return result;
        }
    }
}