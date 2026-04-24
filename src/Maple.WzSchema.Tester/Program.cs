using Maple.StrongId;
using Maple.WzSchema;

Console.WriteLine($"Maple.WzSchema version: {typeof(WzPath).Assembly.GetName().Version}");

var mobId = new MobTemplateId(100100);
Console.WriteLine($"MobImg(100100) = {WzPath.MobImg(mobId)}");

var mapId = new FieldTemplateId(100000000);
Console.WriteLine($"MapImg(100000000) = {WzPath.MapImg(mapId)}");
Console.WriteLine($"MapGroup(100000000) = {WzPath.MapGroup(mapId)}");

Console.WriteLine("OK");
