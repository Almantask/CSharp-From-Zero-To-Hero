using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BootCamp1.Chapter.Tests.Input
{
    /// <summary>
    /// Array sorted in ascending order
    /// </summary>
    public class ArraySortExpectations: IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            // Null or empty array- returns itself.
            yield return new object[] { Arrays.Empty, Arrays.Empty };
            yield return new object[] { Arrays.Null, Arrays.Null };

            // Already sorted array- remains the same.
            yield return new object[] { Arrays.Array3Same, Arrays.Array3Same };
            yield return new object[] { Arrays.TwoElementsAsc, Arrays.TwoElementsAsc };
            yield return new object[] { Arrays.SingleElement, Arrays.SingleElement };

            // Actual sort.
            yield return new object[] { Arrays.TwoElementsDesc, Arrays.TwoElementsAsc };
            yield return new object[] { Arrays.ArrayRandom, new [] { -1, 0, 1, 2, 3 } };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
