using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUIUpdater
{
    private Player player;
    private UI ui;

    public InventoryUIUpdater(Player player, UI ui)
    {
        this.player = player;
        this.ui = ui;
    }

    public void Update()
    {
        ui.ManualUpdateInventory(player);
        ui.ManualUpdateSellFromBackpack(player);
    }
}
