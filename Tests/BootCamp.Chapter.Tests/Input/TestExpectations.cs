using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Tests.Input
{
    public abstract class TestExpectations: IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var input = GetInput();
            foreach(var args in input)
            {
                yield return args;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        protected abstract IEnumerable<object[]> GetInput();
    }
}
