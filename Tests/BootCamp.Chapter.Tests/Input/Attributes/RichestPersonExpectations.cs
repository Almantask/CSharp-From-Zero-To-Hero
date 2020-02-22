using System.Collections.Generic;
using static BootCamp.Chapter.Tests.Input.BalancesInput;

namespace BootCamp.Chapter.Tests.Input
{
    class RichestPersonExpectations : TestExpectations
    {
        protected override IEnumerable<object[]> GetInput()
        {
            return new List<object[]>()
            {
                new object[]{Null, "N/A."},
                new object[]{Empty, "N/A."},
                new object[]{Person1Balance1, "Tom is the richest person. ¤1." },
                new object[]{Person1Balance2, "Tom is the richest person. ¤0." },
                new object[]{Person2Balance1, "Tom is the richest person. ¤1." },
                new object[]{Person3Balance3, "Thor is the richest person. ¤1002." },
                new object[]{Person3Same, "Tom, Gillie and Agnes are the richest people. ¤1." }
            };
        }
    }
}
