using System;
using System.Collections;
using System.Collections.Generic;
using static BootCamp1.Chapter.Tests.Input.Insert.InsertElementExpectations;

namespace BootCamp1.Chapter.Tests.Input.Insert
{
    public class InsertElementAtExpectations: IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            // Index out of bounds- returns original array.
            yield return new object[] { Arrays.Empty, 1, Arrays.Empty };
            yield return new object[] { Arrays.Empty, -1, Arrays.Empty };

            // Null or empty- create a new array with that element.
            yield return new object[] { Arrays.Empty, 0, new[] { ElementToBeInserted } };
            yield return new object[] { Arrays.Null, 0, new[] { ElementToBeInserted } };
            
            yield return new object[] { Arrays.TwoElementsDesc, 1, new[] { 1, ElementToBeInserted, 0 } };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
