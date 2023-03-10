using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadSlotHandler : InventorySlotHandler<HeadClothing>
{
    public HeadSlotHandler(Inventory inventory) : base(inventory)
    {
    }

    protected override List<InventorySlot> GetSlots()
    {
        return new() { inventory.Head };
    }
}
