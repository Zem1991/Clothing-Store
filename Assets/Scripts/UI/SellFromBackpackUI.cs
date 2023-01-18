using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellFromBackpackUI : GenericUI<Inventory>
{
    [Header("SellFromBackpackUI Awake")]
    [SerializeField] protected GridLayoutGroup sellableItemsGrid;
    [SerializeField] protected ItemDescriptionUI itemDisplay;

    [Header("SellFromBackpackUI Runtime")]
    [SerializeField] protected Dictionary<InventorySlot, SellableItemInventorySlotUI> sellableItemSlots;
    
    protected override void Awake()
    {
        base.Awake();
        sellableItemsGrid = GetComponentInChildren<GridLayoutGroup>();
        itemDisplay = GetComponentInChildren<ItemDescriptionUI>();
        sellableItemSlots = new();
    }

    public override void Refresh(Inventory thing)
    {
        if (thing == null)
        {
            Hide();
            return;
        }

        RefreshSellableItems();
        itemDisplay.Refresh(thing.Display);
        Show();
    }

    public void ManualUpdate(Inventory inventory)
    {
        ClearBackpack();
        SellableItemInventorySlotUI prefab = AllPrefabs.Instance.SellableItemInventorySlotUI;
        foreach (InventorySlot slot in inventory.Backpack)
        {
            SellableItemInventorySlotUI slotUI = Instantiate(prefab, sellableItemsGrid.transform);
            sellableItemSlots.Add(slot, slotUI);
        }
        RefreshSellableItems();
    }

    private void RefreshSellableItems()
    {
        foreach (InventorySlot slot in sellableItemSlots.Keys)
        {
            sellableItemSlots.TryGetValue(slot, out SellableItemInventorySlotUI slotUI);
            slotUI.Refresh(slot);
        }
    }

    private void ClearBackpack()
    {
        foreach (SellableItemInventorySlotUI slotUI in sellableItemSlots.Values)
        {
            Destroy(slotUI.gameObject);
        }
        sellableItemSlots = new();
    }
}
