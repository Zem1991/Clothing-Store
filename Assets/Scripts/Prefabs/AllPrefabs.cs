using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllPrefabs : AbstractSingleton<AllPrefabs>
{
    [SerializeField] private BackpackInventorySlotUI backpackInventorySlotUI;
    [SerializeField] private SellableItemInventorySlotUI sellableItemInventorySlotUI;

    public BackpackInventorySlotUI BackpackInventorySlotUI { get => backpackInventorySlotUI; }
    public SellableItemInventorySlotUI SellableItemInventorySlotUI { get => sellableItemInventorySlotUI; }
}
