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
            throw new NotImplementedException();
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
