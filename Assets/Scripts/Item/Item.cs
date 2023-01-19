using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Item
{
    [Header("Item Data")]
    [SerializeField] public readonly ItemData itemData;

    [Header("Item Runtime")]
    [SerializeField] public DateTime spawnDateTime;

    public Item(ItemData itemData)
    {
        this.itemData = itemData;
        spawnDateTime = DateTime.UtcNow;
    }
}
