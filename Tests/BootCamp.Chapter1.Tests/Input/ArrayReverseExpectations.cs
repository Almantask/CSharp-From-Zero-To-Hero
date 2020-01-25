using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BootCamp1.Chapter.Tests.Input
{
    class ArrayReverseExpectations: IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            // Null or empty array- returns itself.
            yield return new object[] { Arrays.Empty, Arrays.Empty };
            yield return new object[] { Arrays.Null, Arrays.Null };

            // Arrays with all the same elements- returns itself.
            yield return new object[] { Arrays.Array3Same, Arrays.Array3Same };
            yield return new object[] { Arrays.SingleElement, Arrays.SingleElement };

            // Actual reverse order.
            yield return new object[] { Arrays.TwoElementsAsc, Arrays.TwoElementsDesc };
            yield return new object[] { Arrays.TwoElementsDesc, Arrays.TwoElementsAsc };
            yield return new object[] { Arrays.ArrayRandom, new [] { 3, -1, 2, 0, 1 } };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
