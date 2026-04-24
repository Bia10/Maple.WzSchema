using BenchmarkDotNet.Attributes;
using Maple.StrongId;

namespace Maple.WzSchema.Benchmarks;

public class WzPathBench
{
    private readonly MobTemplateId _mobId = new(100100);
    private readonly FieldTemplateId _mapId = new(100000000);

    [Benchmark]
    public string MobImg() => WzPath.MobImg(_mobId);

    [Benchmark]
    public string MapImg() => WzPath.MapImg(_mapId);
}
