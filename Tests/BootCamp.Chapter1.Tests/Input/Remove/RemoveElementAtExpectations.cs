using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BootCamp1.Chapter.Tests.Input.Remove
{
    public class RemoveElementAtExpectations : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            const int unimportant = 0;

            // Empty or null- return original.
            yield return new object[] { Arrays.Empty, unimportant, Arrays.Empty };
            yield return new object[] { Arrays.Null, unimportant, Arrays.Null };

            // Invalid index- return original.
            yield return new object[] { Arrays.TwoElementsAsc, -1, Arrays.TwoElementsAsc };
            yield return new object[] { Arrays.TwoElementsAsc, 2, Arrays.TwoElementsAsc };

            // First.
            yield return new object[] { Arrays.TwoElementsAsc, 0, new[] { 1 } };
            // Last.
            yield return new object[] { Arrays.TwoElementsAsc, 1, new[] { 0 } };
            // Middle.
            yield return new object[] { Arrays.ArrayRandom, 2, new[] { 1, 0, -1, 3 } };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
