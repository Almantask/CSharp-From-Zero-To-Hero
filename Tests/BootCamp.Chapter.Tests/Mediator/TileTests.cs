using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Mediator;
using FluentAssertions;
using FluentAssertions.Execution;
using Moq;
using Xunit;

namespace BootCamp.Chapter.Tests.Mediator
{
    public class TileTests
    {
        [Theory]
        [InlineData(true, false)]
        [InlineData(false, true)]
        public void Toggle_Inverts_IsColored(bool isColored, bool expectedIsColored)
        {
            // Arrange
            var gameMock = new Mock<IColorAllGame>();
            var tile = new Tile(isColored, gameMock.Object);

            // Act
            tile.Toggle();
                
            // Assert
            using (new AssertionScope())
            {
                tile.IsColored.Should().Be(expectedIsColored);
                gameMock.Verify(g => g.IsComplete(), Times.Once);
            }
        }
    }
}
