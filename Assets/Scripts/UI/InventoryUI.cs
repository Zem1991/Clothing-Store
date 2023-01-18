using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : GenericUI<Inventory>
{
    [Header("InventoryUI Awake")]
    [SerializeField] protected EquipmentInventorySlotUI head;
    [SerializeField] protected EquipmentInventorySlotUI torso;
    [SerializeField] protected EquipmentInventorySlotUI legs;
    [SerializeField] protected EquipmentInventorySlotUI feet;
    [SerializeField] protected GridLayoutGroup backpackGrid;
    [SerializeField] protected ItemDescriptionUI itemDisplay;

    [Header("InventoryUI Runtime")]
    [SerializeField] protected Dictionary<InventorySlot, BackpackInventorySlotUI> backpackSlots;

    protected override void Awake()
    {
        base.Awake();
        List<EquipmentInventorySlotUI> equipmentSlots = new List<EquipmentInventorySlotUI>(GetComponentsInChildren<EquipmentInventorySlotUI>());
        head = equipmentSlots[0];
        torso = equipmentSlots[1];
        legs = equipmentSlots[2];
        feet = equipmentSlots[3];
        backpackGrid = GetComponentInChildren<GridLayoutGroup>();
        itemDisplay = GetComponentInChildren<ItemDescriptionUI>();
        backpackSlots = new();
    }

    public override void Refresh(Inventory thing)
    {
        if (thing == null)
        {
            Hide();
            return;
        }

        head.Refresh(thing.Head);
        torso.Refresh(thing.Torso);
        legs.Refresh(thing.Legs);
        feet.Refresh(thing.Feet);
        RefreshBackpack();
        itemDisplay.Refresh(thing.Display);
        Show();
    }

    public void ManualUpdate(Inventory inventory)
    {
        ClearBackpack();
        BackpackInventorySlotUI prefab = AllPrefabs.Instance.BackpackInventorySlotUI;
        foreach (InventorySlot slot in inventory.Backpack)
        {
            BackpackInventorySlotUI slotUI = Instantiate(prefab, backpackGrid.transform);
            backpackSlots.Add(slot, slotUI);
        }
        RefreshBackpack();
    }

    private void RefreshBackpack()
    {
        foreach (InventorySlot slot in backpackSlots.Keys)
        {
            backpackSlots.TryGetValue(slot, out BackpackInventorySlotUI slotUI);
            slotUI.Refresh(slot);
        }
    }

    private void ClearBackpack()
    {
        foreach (BackpackInventorySlotUI slotUI in backpackSlots.Values)
        {
            Destroy(slotUI.gameObject);
        }
        backpackSlots = new();
    }
}
