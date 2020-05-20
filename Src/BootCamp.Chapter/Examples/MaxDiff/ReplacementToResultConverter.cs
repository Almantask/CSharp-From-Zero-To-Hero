namespace BootCamp.Chapter.Examples.MaxDiff
{
    public static class DigitReplacer
    {
        public static int Replace(byte[] digits, byte ofX, byte byY)
        {
            if (ofX == ReplacementFinder.DoNotReplace)
            {
                return DigitsConverter.ToInt(digits);
            }

            var newDigits = digits.Clone() as byte[];
            PerformReplacement(newDigits, ofX, byY);
            return DigitsConverter.ToInt(digits);
        }

        private static void PerformReplacement(byte[] digits, byte x, byte y)
        {
            for (byte i = 0; i < digits.Length; i++)
            {
                var current = digits[i];
                if (current == x)
                {
                    digits[i] = y;
                }
            }
        }
    }
}
