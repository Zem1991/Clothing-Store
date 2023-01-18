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
        bool result = SetAsEquipment(item);
        if (!result) result = SendToBackpack(item);
        return result;
    }

    public bool SetAsEquipment(Item item)
    {
        if (new HeadSlotHandler(inventory).Add(item)) return true;
        if (new TorsoSlotHandler(inventory).Add(item)) return true;
        if (new LegsSlotHandler(inventory).Add(item)) return true;
        if (new FeetSlotHandler(inventory).Add(item)) return true;
        return false;
    }

    public bool SetAsEquipment(InventorySlot inventorySlot)
    {
        Item slotItem = inventorySlot.Get();
        bool success = SetAsEquipment(slotItem);
        if (success) inventorySlot.Clear();
        inventory.TrimBackpack();
        return success;
    }

    public bool SendToBackpack(Item item)
    {
        bool result = new BackpackHandler(inventory).Add(item);
        return result;
    }

    public bool SendToBackpack(InventorySlot inventorySlot)
    {
        Item slotItem = inventorySlot.Get();
        bool success = SendToBackpack(slotItem);
        if (success) inventorySlot.Clear();
        inventory.TrimBackpack();
        return success;
    }
}
