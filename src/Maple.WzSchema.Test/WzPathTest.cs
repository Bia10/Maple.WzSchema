namespace Maple.WzSchema.Test;

public class WzPathTest
{
    [Test]
    public async Task MobImg_FormatsSevenDigits()
    {
        var id = new Maple.StrongId.MobTemplateId(100100);
        await Assert.That(WzPath.MobImg(id)).IsEqualTo("0100100.img");
    }

    [Test]
    public async Task MapImg_FormatsNineDigits()
    {
        var id = new Maple.StrongId.FieldTemplateId(100000000);
        await Assert.That(WzPath.MapImg(id)).IsEqualTo("100000000.img");
    }

    [Test]
    public async Task ItemImg_FormatsEightDigits()
    {
        var id = new Maple.StrongId.ItemTemplateId(1002000);
        await Assert.That(WzPath.ItemImg(id)).IsEqualTo("01002000.img");
    }
}
