using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Project Data/Item/Head Clothing")]
public class HeadClothingData : ItemData
{
    public override ItemType GetItemType()
    {
        return ItemType.HEAD_CLOTHING;
    }
}
