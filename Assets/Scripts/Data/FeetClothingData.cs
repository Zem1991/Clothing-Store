using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Project Data/Item/Feet Clothing")]
public class FeetClothingData : ItemData
{
    public override ItemType GetItemType()
    {
        return ItemType.FEET_CLOTHING;
    }
}
