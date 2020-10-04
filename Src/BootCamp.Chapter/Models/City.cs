﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BootCamp.Chapter.Exceptions;

namespace BootCamp.Chapter.Models
{
    public class City
    {
        public int[][] Buildings { get; private set; }
        public SkyLine SkyLine { get; private set; }
        

        public City(int[][] buildings)
        {
            BuildBuildings(buildings);
            SkyLine = SkyLine.CreateSkyLine(Buildings);
        }

        public void BuildBuildings(int[][] buildings)
        {
            ValidateBuildings(buildings);
            Buildings = buildings;
        }

        private void ValidateBuildings(int[][] buildings)
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
                throw new BuildingException($"{nameof(building)} height can not be less than 0 or more than 50 but is {building}");
            }
        }
    }
}
