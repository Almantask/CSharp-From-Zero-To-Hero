using System;
using System.Text;
using BenchmarkDotNet.Attributes;

namespace BootCamp.Chapter
{
    public class StringBenchmarks
    {
        private static string[] _words;
        private static string _wordsString;

        static StringBenchmarks()
        {
            _words = new string[1000000];
            for (var i = 0; i < 1000000; i++)
            {
                _words[i] = "Hello";
            }

            _wordsString = string.Join(',', _words);
        }

        [Benchmark]
        public string SbConcatBench1() => SbConcat(1);

        [Benchmark]
        public string StringConcatBench1() => StringConcat(1);

        [Benchmark]
        public string SbConcatBench10() => SbConcat(10);

        [Benchmark]
        public string StringConcatBench10() => StringConcat(10);

        [Benchmark]
        public string SbConcatBench100() => SbConcat(100);

        [Benchmark]
        public string StringConcatBench100() => StringConcat(100);

        [Benchmark]
        public string SbConcatBench1000() => SbConcat(1000);

        [Benchmark]
        public string StringConcatBench1000() => StringConcat(1000);

        [Benchmark]
        public string SbJoinBench() => SbJoin();

        [Benchmark]
        public string StringJoinBench() => StringJoin();

        [Benchmark]
        public string SbReplaceBench() => SbReplace();

        [Benchmark]
        public string StringReplaceBench() => StringReplace();

        public static string StringConcat(long number)
        {
            var result = "";
            string.Join(",", result);
            for (var i = 0; i < number; i++)
            {
                result += "Hello";
            }

            return result;
        }

        public static string SbConcat(long number)
        {
            var sb = new StringBuilder();
            for (var i = 0; i < number; i++)
            {
                sb.Append("Hello");
            }

            return sb.ToString();
        }

        public static string SbJoin()
        {
            var sb = new StringBuilder();
            var res = sb.AppendJoin(',', _words).ToString();

            return res;
        }

        public static string SbReplace()
        {
            var sb = new StringBuilder();
            var res = sb.Replace('H', 'B').ToString();

            return res;
        }

        public static string StringJoin() => string.Join(',', _words);

        public static string StringReplace() => _wordsString.Replace('H', 'B');


    }
}
