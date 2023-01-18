using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyTransactionHandler
{
    private Player player;

    public MoneyTransactionHandler(Player player)
    {
        this.player = player;
    }

    public bool BuyItem(ItemData itemData)
    {
        Item item = new DataToItem(itemData).Create();
        Inventory inventory = player.PlayerCharacter.GetInventory();
        bool added = inventory.Add(item);
        if (added)
        {
            player.SubtractMoney(itemData.price);
        }
        return added;
    }

    public bool SellItem(InventorySlot inventorySlot)
    {
        Item item = inventorySlot.Eject();
        if (item == null) return false;
        player.AddMoney(item.itemData.price);
        return true;
    }
}
