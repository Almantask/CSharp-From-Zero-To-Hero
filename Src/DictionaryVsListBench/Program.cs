using BenchmarkDotNet.Running;
using System;

namespace DictionaryVsListBench
{
    public class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<DictionaryVsList>();
        }
    }
}
