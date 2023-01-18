using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegsSlotHandler : InventorySlotHandler<LegsClothing>
{
    public LegsSlotHandler(Inventory inventory) : base(inventory)
    {
    }

    protected override List<InventorySlot> GetSlots()
    {
        return new() { inventory.Legs };
    }
}
