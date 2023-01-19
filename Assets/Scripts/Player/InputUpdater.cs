using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputUpdater
{
    //private Inputs inputs;
    //private PlayerUpdateTargets playerUpdateTargets;
    private Player player;

    public InputUpdater(Player player)
    {
        this.player = player;
    }

    public void FixedUpdate()
    {
        if (!IsPlayable()) return;
        Vector2 movementAxes = player.Inputs.MovementAxes();
        player.PlayerCharacter.Move(movementAxes);
    }
    
    public void Update()
    {
        Interactable interactable = player.InteractablePicker.target;
        bool interact = player.Inputs.InteractDown();
        bool inventory = player.Inputs.InventoryDown();
        bool cancel = player.Inputs.CancelDown();

        if (IsPlayable())
        {
            if (interact) interactable?.Interact(player);
            if (inventory) player.UI.ToggleInventory(player);
            if (cancel) player.UI.CancelToggles(player);
        }
        else if (InInventory())
        {
            if (inventory || cancel) player.UI.ToggleInventory(player);
        }
        else if (InSellItems())
        {
            if (cancel) player.UI.ToggleSellFromBackpack(player);
        }
        else if (InDialogue())
        {
            if (interact || cancel) player.DialogueScript?.Interaction();
        }
    }

    private bool IsPlayable()
    {
        return player.GameState.IsPlayable();
    }

    private bool InInventory()
    {
        return player.GameState == GameState.INVENTORY;
    }

    private bool InSellItems()
    {
        return player.GameState == GameState.SELL_ITEMS;
    }

    private bool InDialogue()
    {
        return player.GameState == GameState.DIALOGUE;
    }
}
