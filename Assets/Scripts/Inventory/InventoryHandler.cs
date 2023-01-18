using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryHandler
{
    private Inventory inventory;

    public InventoryHandler(Inventory inventory)
    {
        this.inventory = inventory;
    }

    public bool Add(Item item)
    {
        if (new HeadSlotHandler(inventory).Add(item)) return true;
        if (new TorsoSlotHandler(inventory).Add(item)) return true;
        if (new LegsSlotHandler(inventory).Add(item)) return true;
        if (new FeetSlotHandler(inventory).Add(item)) return true;
        return false;
    }
}
