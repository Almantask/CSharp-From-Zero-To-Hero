using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BootCamp.Chapter.Mediator;
using FluentAssertions;
using FluentAssertions.Execution;
using Moq;
using Xunit;

namespace BootCamp.Chapter.Tests.Mediator
{
    // You don't have to be here for a long time.
    public class ColorAllGameTests
    {
        private const string WinMesage = "Congratulations! You won!";

        private readonly Dictionary<bool, string> Messages = new Dictionary<bool, string>
        {
            {true, WinMesage},
            {false, string.Empty}
        };

        // So we have a game
        // Game has tiles
        // When all tiles are colored- game is complete
        // React to a tile being colored as soon as we click it

        [Fact]
        public void NewGame_HasNoTiles()
        {
            var game = new ColorAllGame();

            var isComplete = game.IsComplete();
            isComplete.Should().BeTrue();
        }

        [Fact]
        public void SetTiles_WhenNoTiles_Give1Tile_HasNoTiles()
        {
            var game = new ColorAllGame(new[] {Mock.Of<ITile>()});

            game.SetTiles(Enumerable.Empty<ITile>());

            var isComplete = game.IsComplete();
            isComplete.Should().BeTrue();
        }

        [Theory]
        [MemberData(nameof(GameOverExpectations))]
        public void IsComplete_Returns_ExpectedIsGameOver(
            IEnumerable<ITile> tiles,
            bool expectedIsGameOver)
        {
            // Arrange
            var fakeConsoleOutput = new StringWriter();
            Console.SetOut(fakeConsoleOutput);
            var game = new ColorAllGame(tiles);

            // Act
            var isGameOver = game.IsComplete();
            
            // Assert
            using (new AssertionScope())
            {
                isGameOver.Should().Be(expectedIsGameOver);
                var output = fakeConsoleOutput.ToString().Trim();
                var expectedMessage = Messages[expectedIsGameOver];
                output.Should().Be(expectedMessage);
            }
        }

        [Fact]
        public void Press_Given_TileIndexExists_TogglesIt()
        {
            // Arrange
            var tileMock = new Mock<ITile>();
            var tiles = new[] {tileMock.Object};
            var game = new ColorAllGame(tiles);

            // Act
            game.Press(0);

            // Assert
            tileMock.Verify(t => t.Toggle());
        }

        [Fact]
        public void Press_Given_TileIndexDoesNotExist_Throws_InvalidGameSetupException()
        {
            // Arrange
            var game = new ColorAllGame(Enumerable.Empty<ITile>());

            // Act
            Action action = () => game.Press(0);

            // Assert
            action.Should()
                .Throw<InvalidGameSetupException>()
                .Which.Message.Should().Contain("Index: 0");
        }

        public static IEnumerable<object[]> GameOverExpectations
        {
            get
            {
                yield return EmptyTiles_GameOver_True;
                yield return OneTile_Uncolored_GameOver_False;
                yield return OneTile_Colored_False;
                yield return TwoTiles_BothColored_True;
            }
        }

        private static object[] EmptyTiles_GameOver_True => 
            new object[] { Enumerable.Empty<ITile>(), true};

        private static object[] OneTile_Uncolored_GameOver_False =>
            new object[] { new ITile[]{ BuildTile(false)}, false };

        private static object[] OneTile_Colored_False =>
            new object[] { new ITile[] { BuildTile(true) }, true };

        private static object[] TwoTiles_BothColored_True =>
            new object[] { new ITile[] { BuildTile(true), BuildTile(true) }, true };

        private static Tile BuildTile(bool isColored) => new Tile(isColored, Mock.Of<IColorAllGame>());
    }
}
