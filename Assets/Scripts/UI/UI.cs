using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    [Header("Awake")]
    [SerializeField] private HUD hud;
    [SerializeField] private InventoryUI inventory;
    [SerializeField] private DialogueUI dialogue;

    [Header("Runtime")]
    [SerializeField] private bool inventoryActive;

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
        inventory.Refresh(inventoryActive ? player.PlayerCharacter.GetInventory() : null);
        dialogue.Refresh(player);
    }

    public void ManualUpdateInventory(Player player)
    {
        inventory.ManualUpdate(player.PlayerCharacter.GetInventory());
    }

    public void ToggleInventory()
    {
        inventoryActive = !inventoryActive;
    }

    public void Cancel()
    {
        inventoryActive = false;
    }
}
