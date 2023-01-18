using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EquipmentInventorySlotUI : InventorySlotUI
{
    [Header("EquipmentInventorySlotUI References")]
    [SerializeField] private TMP_Text itemName;
    [SerializeField] private TMP_Text itemPrice;

    protected override void Awake()
    {
        base.Awake();

        //List<TMP_Text> texts = new List<TMP_Text>(GetComponentsInChildren<TMP_Text>());
        //texts.Remove(slotName);

        //itemName = texts[0];
        //itemPrice = texts[1];
    }

    public override void Refresh(InventorySlot thing)
    {
        base.Refresh(thing);
        Item item = thing.Get();
        bool hasItem = item != null;
        itemName.text = hasItem ? item.itemData.idName : "<empty>";
        itemPrice.text = hasItem ? $"${item.itemData.price}" : null;
    }

    protected override void PointerClick()
    {
        Inventory inventory = inventorySlot.inventory;
        inventory.SendToBackpack(inventorySlot);
    }
}
