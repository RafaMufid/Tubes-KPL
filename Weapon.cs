using System;

public class Weapon
{
    public string Name { get; set; } = string.Empty;
    public int Price { get; set; }

    public override string ToString()
    {
        return $"{Name} (Price: {Price})";
    }
}