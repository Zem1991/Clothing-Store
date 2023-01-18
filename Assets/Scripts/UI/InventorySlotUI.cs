using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public abstract class InventorySlotUI : GenericUI<InventorySlot>, IPointerClickHandler
{
    [Header("InventorySlotUI Awake")]
    [SerializeField] private TMP_Text itemName;
    [SerializeField] private Image iconBack;
    [SerializeField] private Image iconFront;

    [Header("InventorySlotUI Runtime")]
    [SerializeField] protected InventorySlot inventorySlot;

    protected override void Awake()
    {
        base.Awake();

        List<TMP_Text> texts = new List<TMP_Text>(GetComponentsInChildren<TMP_Text>());
        List<Image> sprites = new List<Image>(GetComponentsInChildren<Image>());
        sprites.Remove(background);

        itemName = texts[0];
        iconBack = sprites[0];
        iconFront = sprites[1];
    }

    public override void Refresh(InventorySlot thing)
    {
        inventorySlot = thing;
        Item item = thing.Get();
        bool hasItem = item != null;
        itemName.text = hasItem ? item.itemData.idName : "<empty>";
        iconFront.sprite = item?.itemData.idIcon;
        iconFront.enabled = hasItem;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        PointerClick();
    }

    protected abstract void PointerClick();
}
