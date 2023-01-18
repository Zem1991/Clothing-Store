using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllPrefabs : AbstractSingleton<AllPrefabs>
{
    [SerializeField] private BackpackInventorySlotUI backpackInventorySlotUI;

    public BackpackInventorySlotUI BackpackInventorySlotUI { get => backpackInventorySlotUI; set => backpackInventorySlotUI = value; }
}
