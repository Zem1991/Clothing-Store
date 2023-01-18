using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorsoSlotHandler : InventorySlotHandler<TorsoClothing>
{
    public TorsoSlotHandler(Inventory inventory) : base(inventory)
    {
    }

    protected override List<InventorySlot> GetSlots()
    {
        return new() { inventory.Torso };
    }
}
