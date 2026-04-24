# Maple.WzSchema

![.NET](https://img.shields.io/badge/net10.0-5C2D91?logo=.NET&labelColor=gray)
![C#](https://img.shields.io/badge/C%23-14-239120?labelColor=gray)
[![Build Status](https://github.com/Bia10/Maple.WzSchema/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/Bia10/Maple.WzSchema/actions/workflows/dotnet.yml)
[![codecov](https://codecov.io/gh/Bia10/Maple.WzSchema/branch/main/graph/badge.svg)](https://codecov.io/gh/Bia10/Maple.WzSchema)
[![Nuget](https://img.shields.io/nuget/v/Maple.WzSchema?color=purple)](https://www.nuget.org/packages/Maple.WzSchema/)
[![License](https://img.shields.io/github/license/Bia10/Maple.WzSchema)](https://github.com/Bia10/Maple.WzSchema/blob/main/LICENSE)

MapleStory WZ archive schema constants, node-key definitions, and path navigation utilities. Cross-platform, trimmable and AOT/NativeAOT compatible.

⭐ Please star this project if you like it. ⭐

[Example](#example) | [Example Catalogue](#example-catalogue) | [Public API](docs/PublicApi.md)

## Example

```csharp
// Use WzPath to build type-safe WZ paths from StrongId values
var mobId = new Maple.StrongId.MobTemplateId(100100);
var path = WzPath.MobImg(mobId);
await Assert.That(path).IsEqualTo("0100100.img");
```

For more examples see [Example Catalogue](#example-catalogue).

## Benchmarks

Benchmarks.

### Detailed Benchmarks

#### Comparison Benchmarks

##### TestBench Benchmark Results

###### Results will be populated here after running `dotnet Build.cs comparison-bench` then `dotnet test`

## Example Catalogue

The following examples are available in [ReadMeTest.cs](src/Maple.WzSchema.DocTest/ReadMeTest.cs).

### Example - Empty

```csharp
// Use WzPath to build type-safe WZ paths from StrongId values
var mobId = new Maple.StrongId.MobTemplateId(100100);
var path = WzPath.MobImg(mobId);
await Assert.That(path).IsEqualTo("0100100.img");
```

## Public API Reference

See [docs/PublicApi.md](docs/PublicApi.md) for the complete auto-generated public API reference.

> **Note**: `docs/PublicApi.md` is auto-updated by the `ReadMeTest_PublicApi` test on every `dotnet test` run. Do not edit it manually.
