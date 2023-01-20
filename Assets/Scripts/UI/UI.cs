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
    [SerializeField] private Player player;
    [SerializeField] private bool inventoryActive;
    [SerializeField] private bool sellFromBackpackActive;
    public Player Player { get => player; private set => player = value; }
    public bool InventoryActive { get => inventoryActive; private set => inventoryActive = value; }
    public bool SellFromBackpackActive { get => sellFromBackpackActive; private set => sellFromBackpackActive = value; }

    private void Awake()
    {
        hud = GetComponentInChildren<HUD>();
        inventory = GetComponentInChildren<InventoryUI>();
        sellFromBackpack = GetComponentInChildren<SellFromBackpackUI>();
        dialogue = GetComponentInChildren<DialogueUI>();
    }

    private void Start()
    {
        Refresh(null);
    }

    public void Refresh(Player player)
    {
        Player = player;
        hud.Refresh(player);
        inventory.Refresh(InventoryActive ? player.PlayerCharacter.GetInventory() : null);
        sellFromBackpack.Refresh(SellFromBackpackActive ? player.PlayerCharacter.GetInventory() : null);
        dialogue.Refresh(player?.DialogueScript);
    }

    public void ToggleInventory(Player player)
    {
        InventoryActive = !InventoryActive;
        if (InventoryActive) player.SetGameState(GameState.INVENTORY);
        else player.SetGameState(GameState.NORMAL);
        ManualUpdateInventory(player);
    }

    public void ManualUpdateInventory(Player player)
    {
        if (InventoryActive) inventory.ManualUpdate(player.PlayerCharacter.GetInventory());
    }

    public void ToggleSellFromBackpack(Player player)
    {
        SellFromBackpackActive = !SellFromBackpackActive;
        if (SellFromBackpackActive) player.SetGameState(GameState.SELL_ITEMS);
        else player.SetGameState(GameState.NORMAL);
        ManualUpdateSellFromBackpack(player);
    }

    public void ManualUpdateSellFromBackpack(Player player)
    {
        if (SellFromBackpackActive) sellFromBackpack.ManualUpdate(player.PlayerCharacter.GetInventory());
    }

    public void CancelToggles(Player player)
    {
        InventoryActive = false;
        SellFromBackpackActive = false;
        player.SetGameState(GameState.NORMAL);
    }
}
