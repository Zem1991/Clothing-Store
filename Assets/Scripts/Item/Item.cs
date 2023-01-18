using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Item
{
    [Header("Data")]
    [SerializeField] public readonly ItemData itemData;
    [SerializeField] public DateTime spawnDateTime;

    public Item(ItemData itemData)
    {
        this.itemData = itemData;
        spawnDateTime = DateTime.Now;
    }
}
