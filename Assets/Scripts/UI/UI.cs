using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    [Header("Awake")]
    [SerializeField] private HUD hud;
    [SerializeField] private InventoryUI inventory;
    [SerializeField] private SellFromBackpackUI sellFromBackpack;
    [SerializeField] private DialogueUI dialogue;

    [Header("Runtime")]
    [SerializeField] private bool inventoryActive;
    [SerializeField] private bool sellFromBackpackActive;

    private void Awake()
    {
        hud = GetComponentInChildren<HUD>();
        inventory = GetComponentInChildren<InventoryUI>();
        sellFromBackpack = GetComponentInChildren<SellFromBackpackUI>();
        dialogue = GetComponentInChildren<DialogueUI>();
        Refresh(null);
    }

    public void Refresh(Player player)
    {
        hud.Refresh(player);
        inventory.Refresh(inventoryActive ? player.PlayerCharacter.GetInventory() : null);
        sellFromBackpack.Refresh(sellFromBackpackActive ? player.PlayerCharacter.GetInventory() : null);
        dialogue.Refresh(player?.DialogueScript);
    }

    public void ToggleInventory(Player player)
    {
        inventoryActive = !inventoryActive;
        if (inventoryActive) player.SetGameState(GameState.INVENTORY);
        else player.SetGameState(GameState.NORMAL);
        ManualUpdateInventory(player);
    }

    public void ManualUpdateInventory(Player player)
    {
        if (inventoryActive) inventory.ManualUpdate(player.PlayerCharacter.GetInventory());
    }

    public void ToggleSellFromBackpack(Player player)
    {
        sellFromBackpackActive = !sellFromBackpackActive;
        if (sellFromBackpackActive) player.SetGameState(GameState.SELL_ITEMS);
        else player.SetGameState(GameState.NORMAL);
        ManualUpdateSellFromBackpack(player);
    }

    public void ManualUpdateSellFromBackpack(Player player)
    {
        if (sellFromBackpackActive) sellFromBackpack.ManualUpdate(player.PlayerCharacter.GetInventory());
    }

    public void CancelToggles(Player player)
    {
        inventoryActive = false;
        sellFromBackpackActive = false;
        player.SetGameState(GameState.NORMAL);
    }
}
