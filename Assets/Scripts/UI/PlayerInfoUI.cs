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

    protected override void Awake()
    {
        base.Awake();
        moneyIcon = GetComponentInChildren<Image>();
        moneyText = GetComponentInChildren<TMP_Text>();
    }

    public override void Refresh(Player thing)
    {
        moneyText.text = $"{thing.Money}";
    }
}
