using System;

public class Player
{
    public int Gold { get; set; }
    public Inventory<Weapon> Inventory { get; set; } = new Inventory<Weapon>();

    public Player(int gold)
    {
        Gold = gold;
    }

    public void BuyItem(Weapon item)
    {
        Gold -= item.Price;
        Inventory.AddItem(item);
    }
}

