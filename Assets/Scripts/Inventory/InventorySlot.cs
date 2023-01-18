using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InventorySlot
{
    public readonly Inventory inventory;
    public readonly ItemType itemType;
    [SerializeField] private Item current;

    public InventorySlot(Inventory inventory, ItemType itemType)
    {
        this.inventory = inventory;
        this.itemType = itemType;
        current = null;
    }

    public bool IsEmpty()
    {
        return current == null;
        //return current?.itemData == null;
    }

    public Item Get()
    {
        return current;
    }

    public void Clear()
    {
        current = null;
    }

    public Item Eject()
    {
        Item previous = current;
        current = null;
        return previous;
    }

    public bool Add(Item item)
    {
        if (!IsEmpty()) return false;
        if (!itemType.IsCompatibleWith(item)) return false;
        current = item;
        return true;
    }

    public bool Swap(Item item, out Item previous)
    {
        previous = null;
        if (!itemType.IsCompatibleWith(item)) return false;
        previous = current;
        current = item;
        return true;
    }

    public bool Remove(Item item, out Item previous)
    {
        previous = null;
        if (item == null) return false;
        if (item != current) return false;
        previous = current;
        current = null;
        return true;
    }
}
