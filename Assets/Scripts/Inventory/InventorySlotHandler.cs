using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InventorySlotHandler<T> where T : Item
{
    protected Inventory inventory;

    protected InventorySlotHandler(Inventory inventory)
    {
        this.inventory = inventory;
    }

    public bool Add(Item item)
    {
        T itemCast = item as T;
        if (itemCast == null) return false;
        return Add(itemCast);
    }

    public bool Add(T item)
    {
        bool result = false;
        List<InventorySlot> slotList = GetSlots();
        foreach (var slot in slotList)
        {
            result = slot.Add(item);
            if (result) break;
        }
        return result;
    }

    protected abstract List<InventorySlot> GetSlots();
}
