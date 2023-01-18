using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Project Data/Item/Legs Clothing")]
public class LegsClothingData : ItemData
{
    public override ItemType GetItemType()
    {
        return ItemType.LEGS_CLOTHING;
    }
}
