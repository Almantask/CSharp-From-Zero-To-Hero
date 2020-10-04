using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Models;

namespace BootCamp.Chapter
{
    public static class MaxCityRise
    {
        public static int GetMaxCityRise(City city)
        {
            return SumHeightsTrueIsMaxHeightFalseIsOriginal(true, city) - SumHeightsTrueIsMaxHeightFalseIsOriginal(false, city);

        }
        private static int SumHeightsTrueIsMaxHeightFalseIsOriginal(bool isMax, City city)
        {
            int streetLength = city.Buildings.Length;
            int[][] maxBuildingHeight = MaxBuildingHeight(city, streetLength);

            int sum = 0;

            for (int i = 0; i < streetLength; i++)
            {
                for (int k = 0; k < streetLength; k++)
                {
                    sum += isMax ? maxBuildingHeight[i][k] : city.Buildings[i][k];
                }
            }

            return sum;
        }

        private static int[][] MaxBuildingHeight(City city, int streetLength)
        {
            int[][] maxBuildingHeight = new int[streetLength][];

            for (int i = 0; i < streetLength; i++)
            {
                maxBuildingHeight[i] = new int[streetLength];
                for (int k = 0; k < streetLength; k++)
                {
                    maxBuildingHeight[i][k] = GetMaxHeight(i, k, city);
                }
            }

            return maxBuildingHeight;
        }

        private static int GetMaxHeight(int i, int k, City city)
        {
            return (city.SkyLine.TopView[i] < city.SkyLine.SideView[k]) ? city.SkyLine.TopView[i] : city.SkyLine.SideView[k];
        }
    }
}
