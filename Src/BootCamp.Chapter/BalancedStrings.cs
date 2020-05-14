using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public static class BalancedStrings
    {
        private const char L = 'L';
        private const char R = 'R';
        private const char NonExistingLiteral = '-';

        public static int FindCount(string input)
        {
            var count = 0;
            if (string.IsNullOrEmpty(input)) return count;

            var previous = NonExistingLiteral;
            var isStart = false;
            foreach (var letter in input)
            {
                if (letter == previous) continue;

                previous = letter;
                isStart = !isStart;
                if (!isStart)
                {
                    previous = NonExistingLiteral;
                    count++;
                }
            }

            return count;
        }
    }
}
