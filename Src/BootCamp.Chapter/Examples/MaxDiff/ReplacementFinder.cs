namespace BootCamp.Chapter.Examples.MaxDiff
{
    public static class ReplacementFinder
    {
        public const byte DoNotReplace = 11;

        public static (byte, byte) FindA(byte[] digits)
        {
            const int max = 9;
            for (byte i = 0; i < digits.Length; i++)
            {
                var current = digits[i];
                if (current != max) return (current, max);
            }

            return (DoNotReplace, DoNotReplace);
        }

        public static (byte, byte) FindB(byte[] digits)
        {
            for (byte i = 0; i < digits.Length; i++)
            {
                var current = digits[i];
                // 0- alraedy min
                if (current == 0) continue;
                // cannot be 0- min is 1
                if (i == 0)
                {
                    if (current == 1) continue;
                    if (current > 1) return (current, 1);
                }
                // can be 0- min is 0
                var isPossibleToBe0 = digits[0] != current;
                if (current != 0 && isPossibleToBe0) return (current, 0);
            }

            return (DoNotReplace, DoNotReplace);
        }
    }
}
