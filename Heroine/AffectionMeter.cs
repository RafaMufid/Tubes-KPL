using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_KPL_Kel6.Heroine;

class AffectionMeter
{
    private int affectionValue;
    private Dictionary<int, string> affectionTable;

    public AffectionMeter()
    {
        // Set default value
        affectionValue = 50;

        // Inisialisasi tabel affection
        affectionTable = new Dictionary<int, string>
        {
            { 5, "I wanna kill this guy" },
            { 30, "Hate" },
            { 50, "Friendly" },
            { 80, "Like" },
            { 100, "In Love" }
        };
    }

    public int GetValue()
    {
        return affectionValue;
    }

    public string GetLevel()
    {
        int bestMatch = -1;

        foreach (var entry in affectionTable)
        {
            if (affectionValue >= entry.Key)
            {
                if (entry.Key > bestMatch)
                {
                    bestMatch = entry.Key;
                }
            }
        }

        if (bestMatch != -1)
        {
            return affectionTable[bestMatch];
        }
        else
        {
            return "Unknown";
        }
    }
    
    public void Increase(int amount)
    {
        affectionValue += amount;
        if (affectionValue > 100)
        {
            affectionValue = 100;
        }
    }

    public void Decrease(int amount)
    {
        affectionValue -= amount;
        if (affectionValue < 5)
        {
            affectionValue = 5;
        }
    }
}
