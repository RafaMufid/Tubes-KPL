using System;
using System.Collections.Generic;

public class Shop<T>
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void ShowItems()
    {
        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {items[i]}");
        }
    }

    public int ItemCount => items.Count;

    public T GetItem(int index)
    {
        return items[index];
    }

    public void RemoveItem(T item)
    {
        items.Remove(item);
    }
}