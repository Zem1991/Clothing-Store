using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeetSlotHandler : InventorySlotHandler<FeetClothing>
{
    public FeetSlotHandler(Inventory inventory) : base(inventory)
    {
    }

    protected override List<InventorySlot<FeetClothing>> GetSlots()
    {
        return new() { inventory.Feet };
    }
}
