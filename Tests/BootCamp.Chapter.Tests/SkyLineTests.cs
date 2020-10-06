using System;
using Xunit;
using BootCamp.Chapter.Models;
using BootCamp.Chapter.Exceptions;
using BootCamp.Chapter.Tests.Public;

namespace BootCamp.Chapter.Tests
{
    public class SkyLineTests
    {
        [Theory]
        [InlineData(true, 4, 1, 50)]
        [InlineData(false, 4, 1, 50)]
        public void SkyLine_Given_Buildings_Creates_View(bool isTopView, int citySize, int buildingHeight, int offNumber)
        {
            //Arrange
            int[][] buildings = Builders.BuildBuildings(citySize, buildingHeight);
            buildings[0][0] = offNumber;
            int[] correctView = new int[4] { offNumber, buildingHeight, buildingHeight, buildingHeight };

            //Act
            SkyLine skyLine = new SkyLine(buildings);
            int[] view = isTopView ? skyLine.TopView : skyLine.SideView;

            //Assert
            Assert.Equal(correctView, view);
        }
    }
}
