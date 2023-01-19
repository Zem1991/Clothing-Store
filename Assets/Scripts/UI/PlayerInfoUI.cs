using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfoUI : GenericUI<Player>
{
    [Header("PlayerInfoUI Awake")]
    [SerializeField] private Image moneyIcon;
    [SerializeField] private TMP_Text moneyText;
    [SerializeField] private PlayerInfoButtonsUI buttons;

    protected override void Awake()
    {
        base.Awake();
        List<TMP_Text> texts = new List<TMP_Text>(GetComponentsInChildren<TMP_Text>());

        moneyIcon = GetComponentInChildren<Image>();
        moneyText = texts[0];

        buttons = GetComponentInChildren<PlayerInfoButtonsUI>();
    }

    public override void Refresh(Player thing)
    {
        moneyText.text = $"{thing.Money}";
        buttons.Refresh(thing);
    }

    public void InventoryButton()
    {
        UI ui = GetComponentInParent<UI>();
        ui.ToggleInventory(ui.Player);
    }
}
