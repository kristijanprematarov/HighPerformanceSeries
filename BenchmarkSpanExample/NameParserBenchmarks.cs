using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace BenchmarkSpanExample
{
    [MemoryDiagnoser]
    public class NameParserBenchmarks
    {
        private const string FullName = "Kristijan KPR Prematarov";
        private static readonly NameParser Parser = new NameParser();

        [Benchmark(Baseline = true)]
        public void GetLastName()
        {
            Parser.GetLastName(FullName);
        }
    }
}
