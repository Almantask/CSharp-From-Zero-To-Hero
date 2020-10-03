using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Exceptions;

namespace BootCamp.Chapter.Models
{
    public class City
    {
        private int[][] Buildings { get; set; }
        private SkyLine Skyline { get; set; }
        public int[][] MaxBuildingHeight { get => getMaxBuildingHeight(); }

        public City(int[][] buildings)
        {
            BuildBuildings(buildings);
        }

        public void BuildBuildings(int[][] buildings)
        {
            TestBuildings(buildings);
            Buildings = buildings;
            SetSkyline();
        }

        private void SetSkyline()
        {
            Skyline = new SkyLine(Buildings);
        }

        private int[][] getMaxBuildingHeight()
        {
            int streetLength = Buildings.Length;
            int[][] maxBuildingHeight = new int[streetLength][];

            for (int i = 0; i < streetLength; i++)
            {
                maxBuildingHeight[i] = new int[streetLength];
                for (int k = 0; k < streetLength; k++)
                {
                    maxBuildingHeight[i][k] = GetMaxHeight(i, k);
                }
            }

            return maxBuildingHeight;
        }

        private int GetMaxHeight(int i, int k)
        {
            return (Skyline.TopView[i] < Skyline.SideView[k]) ? Skyline.SideView[k] : Skyline.TopView[i];
        }

        private void TestBuildings(int[][] buildings)
        {
            foreach (int[] street in buildings)
            {
                foreach (int building in street)
                {
                    IsBuildingHeightValid(building);
                }
            }
        }

        private void IsBuildingHeightValid(int building)
        {
            if (building < 0 || building > 50)
            {
                throw new BuildingException($"{nameof(building)} height can not be more than 50 or less than 0 but is {building}");
            }
        }
    }
}
