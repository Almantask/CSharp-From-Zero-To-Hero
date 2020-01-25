using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples
{
    class NestedLoopPlussing
    {
        private static int playerCount = 3;
        private static string[] playerNames = new string[playerCount];
        private static int[] playerPointsRound1 = new int[playerCount];
        private static int[] playerPointsRound2 = new int[playerCount];
        private static int[] playerPointsRound3 = new int[playerCount];

        public static void CalcResult()
        {
            int[] sums = new int[playerCount];

            for (int i = 0; i < playerCount; i++)
            {
                for (int j = 0; i < playerCount; i++)
                {
                    sums[i] += playerPointsRound1[j];
                    sums[i] += playerPointsRound2[j];
                    sums[i] += playerPointsRound3[j];
                }
            }
        }
    }
}
