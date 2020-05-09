using System.Collections.Generic;
using System.Numerics;
using BootCamp.Chapter.Examples;
using BootCamp.Chapter.Examples.Example1;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class ChickenTests
    {
        [Fact]
        public void MoveForward_1_When_Stuck_Stays_InPlace()
        {
            var initialLocation = Vector3.Zero;
            var chicken = new Chicken(Chicken.State.Stuck, initialLocation);

            chicken.MoveForward(1);

            Assert.Equal(initialLocation, chicken.Location);
        }

        [Fact]
        public void MoveForward_1_When_Stable_Moves_1()
        {

        }

        [Fact]
        public void MoveForward_1_When_Scared_Moves_2()
        {

        }

        [Theory]
        [MemberData(nameof(ChickenMovementExpectations))]
        public void MoveForward_1_Appears_In_Expected_Location(Chicken.State state, Vector3 expectedLocation)
        {
            var chicken = new Chicken(state, Vector3.Zero);

            chicken.MoveForward(1);

            Assert.Equal(expectedLocation, chicken.Location);
        }

        public static IEnumerable<object[]> ChickenMovementExpectations
        {
            get
            {
                yield return new object[] { Chicken.State.Stuck, Vector3.Zero };
                yield return new object[] { Chicken.State.Stable, new Vector3(1, 0, 0) };
                yield return new object[] { Chicken.State.Scared, new Vector3(2, 0, 0) };
            }
        }
    }
}
