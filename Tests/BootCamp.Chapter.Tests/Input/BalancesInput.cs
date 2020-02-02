namespace BootCamp.Chapter.Tests.Input
{
    public static class BalancesInput
    {
        public static string[] Null => null;
        public static string[] Empty => new string[0];
        /// <summary>
        /// "Tom"
        /// </summary>
        public static string[] Person1NoBalance => new[] { "Tom" };
        /// <summary>
        /// "Tom, 1"
        /// </summary>
        public static string[] Person1Balance1 => new[] {"Tom, 1"};
        /// <summary>
        /// "Tom, 1, 0"
        /// </summary>
        public static string[] Person1Balance2 => new[] { "Tom, 1, 0" };
        /// <summary>
        /// "Tom, 1", "Gillie, 0"
        /// </summary>
        public static string[] Person2Balance1 => new[] { "Tom, 1", "Gillie, 0" };
        /// <summary>
        /// "Tom, 1, 0", "Gillie, 0, 1"
        /// </summary>
        public static string[] Person2Balance2 => new[] { "Tom, 1, 0", "Gillie, 0, 1" };
        /// <summary>
        /// "Tom, 1, 3, -1", "Gillie, 2, 3, 1", "Thor, 1000, 1001, 1002"
        /// </summary>
        public static string[] Person3Balance3 => new[] { "Tom, 1, 3, -1", "Gillie, 2, 3, 1", "Thor, 1000, 1001, 1002" };
        /// <summary>
        /// "Tom, 1", "Gillie 2, 1", "Thor"
        /// </summary>
        public static string[] Mixed => new[] { "Tom, 1", "Gillie 2, 1", "Thor" };
        /// <summary>
        /// "Tom, 1", "Gillie, 1", "Agnes, 1"
        /// </summary>
        public static string[] Person3Same => new[] { "Tom, 1", "Gillie, 1", "Agnes, 1" };
    }
}
