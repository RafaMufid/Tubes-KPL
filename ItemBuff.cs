using System;

public class ItemBuff : IShopItem
{
    public string Name { get; set; }
    public int Price { get; set; }

    public override string ToString() => $"{Name} (Harga: {Price})";
}
