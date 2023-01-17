using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : GenericUI<Inventory>
{
    public override void Refresh(Inventory inventory)
    {
        if (inventory == null)
        {
            Hide();
            return;
        }

        //throw new System.NotImplementedException();
        Show();
    }
}
