namespace BootCamp.Chapter
{
    public static class Filters
    {
        /// <summary>
        /// Filter whether an int is even
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsNumberEven(int input)
        {
            return input % 2 == 0;
        }

        /// <summary>
        /// Filter whether an int is odd
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsNumberOdd(int input)
        {
            return input % 2 != 0;
        }
    }
}
