using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentInventorySlotUI : InventorySlotUI
{
    protected override void PointerClick()
    {
        Inventory inventory = inventorySlot.inventory;
        inventory.SendToBackpack(inventorySlot);
    }
}
