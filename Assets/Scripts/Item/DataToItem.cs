using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataToItem
{
    private readonly ItemData itemData;

    public DataToItem(ItemData itemData)
    {
        this.itemData = itemData;
    }

    public Item Create()
    {
        Type dataType = itemData.GetType();
        if (dataType == typeof(TorsoClothingData)) return new TorsoClothing(itemData);
        if (dataType == typeof(LegsClothingData)) return new LegsClothing(itemData);
        return null;
    }
}
