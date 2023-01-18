using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public abstract class InventorySlotUI : GenericUI<InventorySlot>, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    [Header("InventorySlotUI References")]
    [SerializeField] protected TMP_Text slotName;
    [SerializeField] private Image iconBack;
    [SerializeField] private Image iconFront;

    [Header("InventorySlotUI Runtime")]
    [SerializeField] protected InventorySlot inventorySlot;

    protected override void Awake()
    {
        base.Awake();

        //List<TMP_Text> texts = new List<TMP_Text>(GetComponentsInChildren<TMP_Text>());
        //slotName = texts[0];

        //List<Image> sprites = new List<Image>(GetComponentsInChildren<Image>());
        //sprites.Remove(background);
        //iconBack = sprites[0];
        //iconFront = sprites[1];
    }

    public override void Refresh(InventorySlot thing)
    {
        inventorySlot = thing;
        Item item = thing.Get();
        bool hasItem = item != null;
        iconFront.sprite = item?.itemData.idIcon;
        iconFront.enabled = hasItem;
    }

    public void OnPointerEnter(PointerEventData eventData) => PointerEnter();
    public void OnPointerExit(PointerEventData eventData) => PointerExit();
    public void OnPointerClick(PointerEventData eventData) => PointerClick();

    protected virtual void PointerEnter()
    {
        inventorySlot.inventory.SetDisplay(inventorySlot);
    }

    protected virtual void PointerExit()
    {
        inventorySlot.inventory.ClearDisplay(inventorySlot);
    }

    protected abstract void PointerClick();
}
