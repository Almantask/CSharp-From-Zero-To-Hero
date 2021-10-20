using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp1.Chapter.Tests.Input.Insert
{
    public abstract class InsertElementExpectations: IEnumerable<object[]>
    {
        public const int ElementToBeInserted = 10;

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
                // Null or empty- create a new array with that element.
                new object[] { Arrays.Empty, new[] { ElementToBeInserted } },
                new object[] { Arrays.Null, new[] { ElementToBeInserted } },
            };
        }

        protected abstract IList<object[]> GetSpecificScenarios();
    }
}
