using System;
using BenchmarkDotNet.Running;

namespace BenchmarkSpanExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<NameParserBenchmarks>(); }
    }
}