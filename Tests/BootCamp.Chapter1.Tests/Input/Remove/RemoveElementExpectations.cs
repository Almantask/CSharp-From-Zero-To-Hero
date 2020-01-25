using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp1.Chapter.Tests.Input.Remove
{
    public abstract class RemoveElementExpectations: IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var scenarios = GetGeneralScenarios().Union(GetSpecificScenarios());
            foreach (var scenario in scenarios)
            {
                yield return scenario;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        protected IList<object[]> GetGeneralScenarios()
        {
            return new List<object[]>
            {
                // Empty or null- return original.
                new object[] { Arrays.Empty, Arrays.Empty },
                new object[] { Arrays.Null, Arrays.Null },

                // Valid removal.
                new object[] { Arrays.Array3Same, new[] { 1, 1 } },
                new object[] { Arrays.SingleElement, new int[0] }
            };
        }

        protected abstract IList<object[]> GetSpecificScenarios();
    }
}
