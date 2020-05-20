namespace BootCamp.Chapter.Examples.MaxDiff
{
    public static class DigitsConverter
    {
        public static byte[] FromInt(int num)
        {
            var numString = num.ToString();
            var digitsCount = numString.Length;
            var digits = new byte[digitsCount];
            for (var index = 0; index < numString.Length; index++)
            {
                digits[index] = (byte)(numString[index] - '0');
            }

            return digits;
        }

        public static int ToInt(byte[] digits)
        {
            var mul = 1;
            var number = 0;
            for (var i = digits.Length - 1; i >= 0; i--)
            {
                number += digits[i] * mul;
                mul *= 10;
            }

            return number;
        }
    }
}
