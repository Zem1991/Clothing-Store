using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : GenericUI<Player>
{
    [Header("HUD Awake")]
    [SerializeField] private MenuCornerUI menuCorner;
    [SerializeField] private PlayerInfoUI playerInfo;
    [SerializeField] private InteractionUI interaction;

    protected override void Awake()
    {
        base.Awake();
        menuCorner = GetComponentInChildren<MenuCornerUI>();
        playerInfo = GetComponentInChildren<PlayerInfoUI>();
        interaction = GetComponentInChildren<InteractionUI>();
    }

    public override void Refresh(Player player)
    {
        if (!player)
        {
            Hide();
            return;
        }

        menuCorner.Refresh(player);
        playerInfo.Refresh(player);
        interaction.Refresh(player.InteractablePicker?.target);
        Show();
    }
}
