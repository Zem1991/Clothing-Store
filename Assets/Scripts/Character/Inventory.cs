using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Inventory
{
    [Header("Equipped")]
    [SerializeField] private InventorySlot<HeadClothing> head;
    [SerializeField] private InventorySlot<TorsoClothing> torso;
    [SerializeField] private InventorySlot<LegsClothing> legs;
    [SerializeField] private InventorySlot<FeetClothing> feet;

    [Header("Backpack")]
    [SerializeField] private List<InventorySlot<Item>> backpack;

	public Inventory()
	{
        head = new();
        torso = new();
        legs = new();
        feet = new();
        backpack = new();
    }

    public bool Add(Item item)
    {
        throw new NotImplementedException();
    }
}
