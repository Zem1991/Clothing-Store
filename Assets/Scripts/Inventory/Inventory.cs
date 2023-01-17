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
    public InventorySlot<HeadClothing> Head { get => head; private set => head = value; }
    public InventorySlot<TorsoClothing> Torso { get => torso; private set => torso = value; }
    public InventorySlot<LegsClothing> Legs { get => legs; private set => legs = value; }
    public InventorySlot<FeetClothing> Feet { get => feet; private set => feet = value; }

    [Header("Backpack")]
    [SerializeField] private List<InventorySlot<Item>> backpack;
    public List<InventorySlot<Item>> Backpack { get => backpack; private set => backpack = value; }

    public Inventory()
	{
        Head = new();
        Torso = new();
        Legs = new();
        Feet = new();
        Backpack = new();
    }

    public bool Add(Item item)
    {
        InventoryHandler inventoryHandler = new(this);
        return inventoryHandler.Add(item);
    }
}
