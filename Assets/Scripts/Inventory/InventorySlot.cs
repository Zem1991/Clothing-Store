using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InventorySlot<T> where T : Item
{
    [SerializeField] private T current;

    public InventorySlot()
    {
        current = null;
    }

    public bool IsEmpty()
    {
        return current == null;
        //return current?.itemData == null;
    }

    public T Get()
    {
        return current;
    }

    public void Clear()
    {
        current = null;
    }

    public T Eject()
    {
        T previous = current;
        current = null;
        return previous;
    }

    public bool Add(T item)
    {
        if (!IsEmpty()) return false;
        current = item;
        Debug.Log($"{item.itemData.idName} on slot");
        return true;
    }

    public bool Swap(T item, out T previous)
    {
        previous = current;
        current = item;
        return true;
    }

    public bool Remove(T item, out T previous)
    {
        previous = null;
        if (item == null) return false;
        if (item != current) return false;
        previous = current;
        current = null;
        return true;
    }
}
