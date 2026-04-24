using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using Maple.StrongId;

namespace Maple.WzSchema.ComparisonBenchmarks;

[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory, BenchmarkLogicalGroupRule.ByParams)]
[BenchmarkCategory("0")]
public class TestBench
{
    [Params(25_000)]
    public int Count { get; set; }

    private readonly MobTemplateId _mobId = new(100100);

    [Benchmark(Baseline = true)]
    public string Maple_WzSchema______() => WzPath.MobImg(_mobId);
}
