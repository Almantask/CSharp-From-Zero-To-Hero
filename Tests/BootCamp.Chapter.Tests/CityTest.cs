using System;
using Xunit;
using BootCamp.Chapter.Models;
using BootCamp.Chapter.Exceptions;
using BootCamp.Chapter.Tests.Public;

namespace BootCamp.Chapter.Tests
{
    public class CityTest
    {
        [Theory]
        [InlineData( 1, -1)]
        [InlineData(1, 51)]
        public void City_Given_BadBuildings_Throws_BuildingException(int citySize, int buildingHeight)
        {
            int[][] buildings = Builders.BuildBuildingsArray(citySize, buildingHeight);
            City city;

            Action action = () => city = new City(buildings);

            Assert.Throws<BuildingException>(action);
        }

        /*
        [Theory]
        [InlineData(0, 3, 1, 5)]
        [InlineData(1, 3, 1, 5)]
        [InlineData(2, 3, 1, 5)]
        public void City_Given_Buildinging_Returns_Correct_MaxBuildingHeight(int offPlace, int citySize, int buildingHeight, int offNumber)
        {
            //Arrange
            int[][] buildings = BuildBuildingsArray(citySize, buildingHeight);
            buildings[offPlace][offPlace] = offNumber;
            int[][] correctMaxBuildingHeight = GetMaxBuildingsArrArr(citySize, buildingHeight, offNumber, offPlace);

            //Act
            City city = new City(buildings);
            int[][] MaxHeightBuildings = city.MaxBuildingHeight;

            //Assert
            Assert.Equal(correctMaxBuildingHeight, MaxHeightBuildings);
        }
        
        private int[][] GetMaxBuildingsArrArr(int citySize, int buildingHeight, int offNumber, int offPlace)
        {
            int[][] buildings = new int[citySize][];

            for (int i = 0; i < citySize; i++)
            {
                buildings[i] = new int[citySize];
                for (int k = 0; k < citySize; k++)
                {
                    bool isOffPlace = (i == offPlace || k == offPlace);
                    buildings[i][k] = isOffPlace ? offNumber : buildingHeight;
                }
            }
            return buildings;
        }
        */
    }
}
