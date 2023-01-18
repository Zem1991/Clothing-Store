using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Project Data/Item/Torso Clothing")]
public class TorsoClothingData : ItemData
{
    public override ItemType GetItemType()
    {
        return ItemType.TORSO_CLOTHING;
    }
}
