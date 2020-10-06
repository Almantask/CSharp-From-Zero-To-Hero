using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Models;

namespace BootCamp.Chapter
{
    public static class MaxCityRise
    {
        /// <summary>
        /// Calculates the Maximum amount a city can rise without changing the view.
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        public static int GetMaxCityRise(City city)
        {
            return SumOfAllBuildingsMaxHeight(city) - SumOfAllBuildings(city);
        }

        /// <summary>
        /// First Calculates the maximum amount a city can rise and then returns the sum of all building heights.
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        private static int SumOfAllBuildingsMaxHeight(City city)
        {
            int cityWidth = city.Buildings.Length;
            int[][] maxBuildingHeight = CalculateMaxBuildingsHeight(city, cityWidth);

            int sum = 0;

            for (int i = 0; i < cityWidth; i++)
            {
                for (int k = 0; k < cityWidth; k++)
                {
                    sum += maxBuildingHeight[i][k];
                }
            }

            return sum;
        }

        /// <summary>
        /// Returns the sum of all current build Buildings
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        private static int SumOfAllBuildings(City city)
        {
            int cityWidth = city.Buildings.Length;
            int sum = 0;

            for (int i = 0; i < cityWidth; i++)
            {
                for (int k = 0; k < cityWidth; k++)
                {
                    sum += city.Buildings[i][k];
                }
            }

            return sum;
        }

        /// <summary>
        /// Calculates the maximum amount the Buildings can rise
        /// </summary>
        /// <param name="city"></param>
        /// <param name="cityWidth">the Width of the city</param>
        /// <returns>Buildings</returns>
        private static int[][] CalculateMaxBuildingsHeight(City city, int cityWidth)
        {
            int[][] maxBuildingHeight = new int[cityWidth][];

            for (int i = 0; i < cityWidth; i++)
            {
                maxBuildingHeight[i] = new int[cityWidth];
                for (int k = 0; k < cityWidth; k++)
                {
                    maxBuildingHeight[i][k] = GetMaxHeight(i, k, city);
                }
            }

            return maxBuildingHeight;
        }

        /// <summary>
        /// returns the lowest of the 2 views so the view does not change
        /// </summary>
        /// <param name="i"></param>
        /// <param name="k"></param>
        /// <param name="city"></param>
        /// <returns></returns>
        private static int GetMaxHeight(int i, int k, City city)
        {
            return (city.SkyLine.TopView[i] < city.SkyLine.SideView[k]) ? city.SkyLine.TopView[i] : city.SkyLine.SideView[k];
        }
    }
}
