using System.Collections.Generic;
using static BootCamp.Chapter.Tests.Input.BalancesInput;

namespace BootCamp.Chapter.Tests.Input
{
    public class HighestHistoricBalanceExpectations: TestExpectations
    {
        protected override IEnumerable<object[]> GetInput()
        {
            return new List<object[]>()
            {
                new object[]{Null, "N/A"},
                new object[]{Empty, "N/A"},
                new object[]{Person1Balance1, "Tom at most had 1"}
            };
        }
    }
}
