using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllPrefabs : AbstractSingleton<AllPrefabs>
{
    [SerializeField] private AudioSourceOneShot audioSourceOneShot;
    [SerializeField] private BackpackInventorySlotUI backpackInventorySlotUI;
    [SerializeField] private SellableItemInventorySlotUI sellableItemInventorySlotUI;

    public AudioSourceOneShot AudioSourceOneShot { get => audioSourceOneShot; }
    public BackpackInventorySlotUI BackpackInventorySlotUI { get => backpackInventorySlotUI; }
    public SellableItemInventorySlotUI SellableItemInventorySlotUI { get => sellableItemInventorySlotUI; }
}
