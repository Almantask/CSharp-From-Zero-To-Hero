using System;
using BenchmarkDotNet.Running;
using BootCamp.Chapter.Examples.Deconstruction;
using BootCamp.Chapter.Examples.ExpressionTrees;
using BootCamp.Chapter.Examples.Preprocessor;
using BootCamp.Chapter.Examples.Reflection;
using BootCamp.Chapter.Examples.Tuple;
using BootCamp.Chapter.Examples.UnsafeCode;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("--- Tuple ---");
            //TupleDemo.Run();
            //DeconstructionDemo.Run();
            //Console.WriteLine("--- Unsafe code ---");
            //UnsafeCodeDemo.Run();
            //Console.WriteLine("--- Expression trees -- ");
            //ExpressionTreesDemo.Run();
            //Console.WriteLine("--- Reflection ---");
            //ReflectionDemo.Run();
            //Console.WriteLine("--- Preprocessor ---");
            //PreoprocessorDemo.Run();
            //DemoStringCreate();

            var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
        }

        private static void DemoStringCreate()
        {
            const string text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            var withA = String.Create(text.Length, text, Action);
            Console.WriteLine(withA);
        }

        private static void Action(Span<char> span, string arg)
        {
            for (int i = 0; i < arg.Length; i++)
            {
                span[i] = arg[i];
            }
            span[10] = 'c';
        }
    }
}
