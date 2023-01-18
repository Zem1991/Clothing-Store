using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackpackInventorySlotUI : InventorySlotUI
{
    protected override void PointerClick()
    {
        Inventory inventory = inventorySlot.inventory;
        inventory.SetAsEquipment(inventorySlot);
    }
}
