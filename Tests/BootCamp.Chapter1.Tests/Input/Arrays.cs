namespace BootCamp1.Chapter.Tests.Input
{
    public static class Arrays
    {
        public static int[] Null => null;
        
        public static int[] Empty => new int[0];

        public static int[] SingleElement => new[] {1};

        /// <summary>
        /// 1, 0.
        /// </summary>
        public static int[] TwoElementsDesc => new[] {1, 0};

        /// <summary>
        /// 0, 1.
        /// </summary>
        public static int[] TwoElementsAsc => new[] {0, 1};

        /// <summary>
        /// 1, 0, 2, -1, 3.
        /// </summary>
        public static int[] ArrayRandom => new[] { 1, 0, 2, -1, 3 };

        /// <summary>
        /// 1, -1, 1.
        /// </summary>
        public static int[] Array2Equal => new[] { 1, -1, 1 };

        /// <summary>
        /// 1, 1, 1.
        /// </summary>
        public static int[] Array3Same => new[] { 1, 1, 1 };
    }
}
