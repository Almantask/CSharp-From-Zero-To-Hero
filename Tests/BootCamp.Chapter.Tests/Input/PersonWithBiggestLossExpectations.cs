using System.Collections.Generic;
using static BootCamp.Chapter.Tests.Input.BalancesInput;
namespace BootCamp.Chapter.Tests.Input
{
    class PersonWithBiggestLossExpectations : TestExpectations
    {
        protected override IEnumerable<object[]> GetInput()
        {
            return new List<object[]>()
            {
                new object[]{Null, "N/A."},
                new object[]{Empty, "N/A."},
                new object[]{Person1Balance1, "N/A." },
                new object[]{Person1Balance2, "Tom lost the most money. -¤1." },
                new object[]{Person2Balance1, "N/A." },
                new object[]{Person3Balance3, "Tom lost the most money. -¤4." },
                new object[]{Person3Same, "N/A." }
            };
        }
    }
}
