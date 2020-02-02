using System;
using System.Collections;
using System.Collections.Generic;

namespace BootCamp.Chapter.Tests
{
    public class TableMessageInput: IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var expectedResult0 = $"+-----+{Environment.NewLine}" +
                                  $"|Hello|{Environment.NewLine}" +
                                  $"+-----+{Environment.NewLine}";
            yield return new object[]{"Hello", 0, expectedResult0};

            var expectedResultMultiline = $"+------+{Environment.NewLine}" +
                                          $"|Hello |{Environment.NewLine}" +
                                          $"|World!|{Environment.NewLine}" +
                                          $"+------+{Environment.NewLine}";
            yield return new object[] { $"Hello{Environment.NewLine}World!", 0, expectedResultMultiline };

            var expectedResult1 = $"+-------+{Environment.NewLine}" +
                                  $"|       |{Environment.NewLine}" +
                                  $"| Hello |{Environment.NewLine}" +
                                  $"|       |{Environment.NewLine}" +
                                  $"+-------+{Environment.NewLine}";
            yield return new object[] { "Hello", 1, expectedResult1 };

            var expectedResultEmpty = "";
            yield return new object[] { "", 0, "" };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}