namespace BootCamp.Chapter.Examples.MaxDiff
{
    public static class MaxDiffSolution
    {
        public static int Solve(int num)
        {
            var digits = DigitsConverter.FromInt(num);
            var (ax, ay) = ReplacementFinder.FindA(digits);
            var (bx, by) = ReplacementFinder.FindB(digits);

            var a = DigitReplacer.Replace(digits, ax, ay);
            var b = DigitReplacer.Replace(digits, bx, by);

            return a - b;
        }
    }


}
