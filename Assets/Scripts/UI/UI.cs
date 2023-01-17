using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    [Header("Awake")]
    [SerializeField] private HUD hud;
    [SerializeField] private InventoryUI inventory;
    [SerializeField] private DialogueUI dialogue;

    private void Awake()
    {
        hud = GetComponentInChildren<HUD>();
        inventory = GetComponentInChildren<InventoryUI>();
        dialogue = GetComponentInChildren<DialogueUI>();
        Refresh(null);
    }

    //public void Refresh(PlayerUpdateTargets playerUpdateTargets)
    //{
    //    PlayerCharacter playerCharacter = playerUpdateTargets.playerCharacter;
    //    hud.Refresh(playerCharacter);
    //}

    public void Refresh(Player player)
    {
        hud.Refresh(player);
        //PlayerCharacter playerCharacter = player.PlayerCharacter;
    }
}
