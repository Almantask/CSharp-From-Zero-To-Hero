using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Tests.Public
{
    public static class Builders
    {
        public static int[][] BuildBuildings(int citySize, int buildingHeight)
        {
            int[][] buildings = new int[citySize][];
            for (int i = 0; i < citySize; i++)
            {
                buildings[i] = new int[citySize];
                for (int k = 0; k < citySize; k++)
                {
                    buildings[i][k] = buildingHeight;
                }
            }

            return buildings;
        }
    }
}
