using System.Linq;

namespace BootCamp.Chapter.Examples.ProblemSolving
{
    public static class Chips
    {
        public static int MoveAllToCheapestPlace(int[] input)
        {
            if (input.Length < 2) return 0;

            return input.GroupBy(c => c % 2)
                .Min(g => g.Count());
        }
    }
}
