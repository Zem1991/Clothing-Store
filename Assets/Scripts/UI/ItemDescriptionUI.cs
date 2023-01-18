using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;

public class ItemDescriptionUI : GenericUI<InventorySlot>
{
    [Header("ItemDescriptionUI Awake")]
    [SerializeField] protected TMP_Text itemDescription;
    [SerializeField] protected TMP_Text itemSpawnDateTime;

    protected override void Awake()
    {
        base.Awake();
        List<TMP_Text> texts = new List<TMP_Text>(GetComponentsInChildren<TMP_Text>());
        itemDescription = texts[0];
        itemSpawnDateTime = texts[1];
        Refresh(null);
    }

    public override void Refresh(InventorySlot inventorySlot)
    {
        Item item = inventorySlot?.Get();
        if (item == null)
        {
            itemDescription.text = null;
            itemSpawnDateTime.text = null;
        }
        else
        {
            itemDescription.text = item.itemData.description;
            itemSpawnDateTime.text = item.spawnDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture);
            ToString();
        }
        Show();
    }
}
