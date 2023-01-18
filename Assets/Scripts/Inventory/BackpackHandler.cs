using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackpackHandler
{
    private Inventory inventory;

    public BackpackHandler(Inventory inventory)
    {
        this.inventory = inventory;
    }

    public bool Add(Item item)
    {
        InventorySlot backpackSlot = new(inventory, ItemType.UNSPECIFIED);
        backpackSlot.Add(item);
        inventory.Backpack.Add(backpackSlot);
        return true;
    }
}
