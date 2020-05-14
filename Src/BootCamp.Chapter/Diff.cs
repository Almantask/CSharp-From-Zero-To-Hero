using System;

namespace BootCamp.Chapter
{
    public static class MaxDiffSolution
    {
        private const byte DoNotReplace = 11;

        public static int Solve(int num)
        {
            var digits = ToDigits(num);
            (var ax, var ay) = FindAReplacements(digits);
            (var bx, var by) = FindBReplacements(digits);

            var a = GetReplacementResult(digits, ax, ay);
            var b = GetReplacementResult(digits, bx, by);

            return a - b;
        }

        private static byte[] ToDigits(int num)
        {
            var numString = num.ToString();
            var digitsCount = numString.Length;
            var digits = new byte[digitsCount];
            for (var index = 0; index < numString.Length; index++)
            {
                digits[index] = (byte)(numString[index]- '0');
            }

            return digits;
        }

        private static (byte, byte) FindAReplacements(byte[] digits)
        {
            const int max = 9;
            for (byte i = 0; i < digits.Length; i++)
            {
                var current = digits[i];
                if (current != max) return (current, max);
            }

            return (DoNotReplace, DoNotReplace);
        }

        private static (byte, byte) FindBReplacements(byte[] digits)
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

        private static int GetReplacementResult(byte[] digits, byte x, byte y)
        {
            if (x == DoNotReplace) return ToInt(digits);
            var newDigits = digits.Clone() as byte[];
            ReplaceAllOccurencesOfXByY(x, y, newDigits);
            return ToInt(newDigits);
        }

        private static void ReplaceAllOccurencesOfXByY(byte x, byte y, byte[] digits)
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

        private static int ToInt(byte[] digits)
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
