using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace DictionaryVsListBench
{
    [MemoryDiagnoser]
    public class DictionaryVsList
    {
        //private readonly Dictionary<int, int> _dictionary10 = BuildDictionary(10);
        //private readonly Dictionary<int, int> _dictionary100 = BuildDictionary(100);
        //private readonly Dictionary<int, int> _dictionary1000 = BuildDictionary(1000);
        //private readonly Dictionary<int, int> _dictionary10000 = BuildDictionary(10000);
        //private readonly Dictionary<int, int> _dictionary100000 = BuildDictionary(100000);
        //private readonly Dictionary<int, int> _dictionary1000000 = BuildDictionary(1000000);
        //private readonly Dictionary<int, int> _dictionary10000000 = BuildDictionary(10000000);
        private readonly int[] _array10 = BuildArray(10);
        private readonly int[] _array100 = BuildArray(100);
        private readonly int[] _array1000 = BuildArray(1000);
        private readonly int[] _array10000 = BuildArray(10000);
        private readonly int[] _array100000 = BuildArray(100000);
        private readonly int[] _array1000000 = BuildArray(1000000);
        private readonly int[] _array10000000 = BuildArray(10000000);

        //[Benchmark]
        //public void DictionaryLookupWith10() => Lookup(_dictionary10, 9);
        //[Benchmark]
        //public void DictionaryLookupWith100() => Lookup(_dictionary100, 99);
        //[Benchmark]
        //public void DictionaryLookupWith1000() => Lookup(_dictionary1000, 999);
        //[Benchmark]
        //public void DictionaryLookupWith10000() => Lookup(_dictionary10000, 9999);
        //[Benchmark]
        //public void DictionaryLookupWith100000() => Lookup(_dictionary100000, 99999);
        //[Benchmark]
        //public void DictionaryLookupWith1000000() => Lookup(_dictionary1000000, 999999);
        //[Benchmark]
        //public void DictionaryLookupWith10000000() => Lookup(_dictionary10000000, 9999999);

        private static int Lookup(Dictionary<int, int> dic, int key)
        {
            return dic[key];
        }

        private static Dictionary<int, int> BuildDictionary(int count)
        {
            var dictionary = new Dictionary<int, int>();
            for (var i = 0; i < count; i++)
            {
                dictionary.Add(i, i);
            }

            return dictionary;
        }

        //[Benchmark]
        //public void ArrayLookupWith10() => Lookup(_array10, 9);
        //[Benchmark]
        //public void ArrayLookupWith100() => Lookup(_array100, 99);
        //[Benchmark]
        //public void ArrayLookupWith1000() => Lookup(_array1000, 999);
        //[Benchmark]
        //public void ArrayLookupWith10000() => Lookup(_array10000, 9999);
        //[Benchmark]
        //public void ArrayLookupWith100000() => Lookup(_array100000, 99999);
        //[Benchmark]
        //public void ArrayLookupWith1000000() => Lookup(_array1000000, 999999);
        //[Benchmark]
        //public void ArrayLookupWith10000000() => Lookup(_array10000000, 9999999);

        private static int Lookup(int[] array, int key)
        {
            return array[key];
        }

        private static int[] BuildArray(int count)
        {
            var array = new int[count];
            for (var i = 0; i < count; i++)
            {
                array[i] = i;
            }

            return array;
        }

        //[Benchmark]
        //public void DictionaryBuild10() => BuildDictionary(10);
        //[Benchmark]
        //public void DictionaryBuild100() => BuildDictionary(100);
        //[Benchmark]
        //public void DictionaryBuild1000() => BuildDictionary(1000);
        //[Benchmark]
        //public void DictionaryBuild10000() => BuildDictionary(10000);
        //[Benchmark]
        //public void DictionaryBuild100000() => BuildDictionary(100000);
        //[Benchmark]
        //public void DictionaryBuild1000000() => BuildDictionary(1000000);
        //[Benchmark]
        //public void DictionaryBuild10000000() => BuildDictionary(10000000);

        [Benchmark]
        public void ArrayBuild10() => BuildArray(10);
        [Benchmark]
        public void ArrayBuild100() => BuildArray(100);
        [Benchmark]
        public void ArrayBuild1000() => BuildArray(1000);
        //[Benchmark]
        //public void ArrayBuild10000() => BuildArray(10000);
        //[Benchmark]
        //public void ArrayBuild100000() => BuildArray(100000);
        //[Benchmark]
        //public void ArrayBuild1000000() => BuildArray(1000000);
        //[Benchmark]
        //public void ArrayBuild10000000() => BuildArray(10000000);
    }
}
