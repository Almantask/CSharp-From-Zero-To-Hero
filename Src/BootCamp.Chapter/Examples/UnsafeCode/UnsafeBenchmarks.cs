using System;
using System.Text;
using BenchmarkDotNet.Attributes;
namespace BootCamp.Chapter.Examples.UnsafeCode
{
    [MemoryDiagnoser]
    public class UnsafeBenchmarks
    {
        private readonly string _text = "aaaaaaaaaaaaaaaaaaaasaaaaaa";

        //[Benchmark]
        //public void CapitalizeNormalBench() => CapitalizeNormal();

        //[Benchmark]
        //public void CapitalizeUnsafeBench() => CapitalizeUnsafe();

        //[Benchmark]
        //public void ReplaceAt10StringCreate() => ReplaceAt10SystemCreate();

        //[Benchmark]
        //public void ReplaceAt10SbBench() => ReplaceAt10Sb();

        [Benchmark]
        public void ReplaceAt10UnsafeBench() => ReplaceAt10Unsafe();

        [Benchmark]
        public void ReplaceAt10SystemCreateCopyToSpanBench() => ReplaceAt10SystemCreateCopyToSpan();

        private void CapitalizeNormal()
        {
            var text = _text;
            text = char.ToUpper(text[0]) + text.Substring(1);
        }

        private void CapitalizeUnsafe()
        {
            var text = new ShortMutableString(_text);
            text[0] = char.ToUpper(text[0]);
        }

        private void ReplaceAt10Sb()
        {
            var sb = new StringBuilder(_text);
            sb.Remove(10, 1);
            sb.Insert(10, 'c');
        }

        private void ReplaceAt10SystemCreate()
        {
            var text = String.Create(_text.Length, _text, Set10thCharToC);
        }

        private void Set10thCharToC(Span<char> span, string arg)
        {
            for (int i = 0; i < arg.Length; i++)
            {
                span[i] = arg[i];
            }
            span[10] = 'c';
        }

        private void ReplaceAt10SystemCreateCopyToSpan()
        {
            String.Create(
                _text.Length,
                _text, 
                (span, state) 
                =>
                {
                    state.AsSpan().CopyTo(span);
                    span[0] = 'c';
                });
        }

        

        private void ReplaceAt10Unsafe()
        {
            var text = new ShortMutableString(_text) {[10] = 'c'};
        }
    }
}
