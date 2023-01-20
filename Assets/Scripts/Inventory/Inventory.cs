using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Inventory
{
    private Action OnChange;

    [Header("Equipped")]
    [SerializeField] private InventorySlot head;
    [SerializeField] private InventorySlot torso;
    [SerializeField] private InventorySlot legs;
    [SerializeField] private InventorySlot feet;
    public InventorySlot Head { get => head; private set => head = value; }
    public InventorySlot Torso { get => torso; private set => torso = value; }
    public InventorySlot Legs { get => legs; private set => legs = value; }
    public InventorySlot Feet { get => feet; private set => feet = value; }

    [Header("Backpack")]
    [SerializeField] private List<InventorySlot> backpack;
    public List<InventorySlot> Backpack { get => backpack; private set => backpack = value; }

    [Header("Runtime")]
    private CharacterAnimator characterAnimator;
    private Player player;
    private InventorySlot display;
    public CharacterAnimator CharacterAnimator { get => characterAnimator; private set => characterAnimator = value; }
    public Player Player { get => player; private set => player = value; }
    public InventorySlot Display { get => display; private set => display = value; }

    public Inventory(CharacterAnimator characterAnimator)
	{
        Head = new(this, ItemType.HEAD_CLOTHING);
        Torso = new(this, ItemType.TORSO_CLOTHING);
        Legs = new(this, ItemType.LEGS_CLOTHING);
        Feet = new(this, ItemType.FEET_CLOTHING);
        Backpack = new();

        CharacterAnimator = characterAnimator;
        Player = null;
        Display = null;
    }

    public bool Add(Item item)
    {
        InventoryHandler inventoryHandler = new(this);
        bool result = inventoryHandler.Add(item);
        InvokeOnChange();
        return result;
    }

    public bool SetAsEquipment(InventorySlot inventorySlot)
    {
        InventoryHandler inventoryHandler = new(this);
        bool result = inventoryHandler.SetAsEquipment(inventorySlot);
        InvokeOnChange();
        return result;
    }

    public bool SendToBackpack(InventorySlot inventorySlot)
    {
        InventoryHandler inventoryHandler = new(this);
        bool result = inventoryHandler.SendToBackpack(inventorySlot);
        InvokeOnChange();
        return result;
    }

    public void TrimBackpack()
    {
        List<InventorySlot> newBackpack = new();
        foreach (InventorySlot slot in Backpack)
        {
            if (slot.IsEmpty()) continue;
            newBackpack.Add(slot);
        }
        Backpack = newBackpack;
    }

    public void InvokeOnChange()
    {
        TrimBackpack();
        CharacterAnimator.InventoryChange(this);
        OnChange?.Invoke();

        ////Sometimes plays several times on the same singular change.
        //new SystemSoundEffectPlayer().ConfirmAction();
    }

    public void ClearDisplay(InventorySlot inventorySlot)
    {
        if (Display == inventorySlot) Display = null;
    }

    public void SetOwner(Player player) => Player = player;
    public void SetDisplay(InventorySlot inventorySlot) => Display = inventorySlot;
    public void SetOnChange(Action action) => OnChange = action;
}
