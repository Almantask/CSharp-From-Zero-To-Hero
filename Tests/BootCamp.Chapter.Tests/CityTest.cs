using System;
using Xunit;
using BootCamp.Chapter.Models;
using BootCamp.Chapter.Exceptions;

namespace BootCamp.Chapter.Tests
{
    public class CityTest
    {
        [Theory]
        [InlineData( 1, -1)]
        [InlineData(1, 51)]
        public void City_Given_BadBuildings_Throws_BuildingException(int citySize, int buildingHeight)
        {
            int[][] buildings = BuildBuildingsArray(citySize, buildingHeight);
            City city;

            Action action = () => city = new City(buildings);

            Assert.Throws<BuildingException>(action);
        }

        [Theory]
        [InlineData(true, 4, 1, 50)]
        [InlineData(false, 4, 1, 50)]
        public void SkyLine_Given_Buildings_Creates_View(bool isTopView, int citySize, int buildingHeight, int offNumber)
        {
            //Arrange
            int[][] buildings = BuildBuildingsArray(citySize, buildingHeight);
            buildings[0][0] = offNumber;
            int[] correctView = new int[4] { offNumber, buildingHeight , buildingHeight, buildingHeight };

            //Act
            SkyLine skyLine = new SkyLine(buildings);
            int[] view = isTopView ? skyLine.TopView : skyLine.SideView;

            //Assert
            Assert.Equal(correctView, view);
        }

        private int[][] BuildBuildingsArray(int citySize, int buildingHeight)
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
