using System;
using System.Collections.Generic;

public class Inventory<T>
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void ShowItems()
    {
        foreach (var item in items)
        {
            Console.WriteLine($"- {item}");
        }
    }
}