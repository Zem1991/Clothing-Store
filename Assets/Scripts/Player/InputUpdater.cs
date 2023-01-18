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

    //public InputUpdater(Inputs inputs, PlayerUpdateTargets playerUpdateTargets)
    //{
    //    this.inputs = inputs;
    //    this.playerUpdateTargets = playerUpdateTargets;
    //}

    public void FixedUpdate()
    {
        Vector2 movementAxes = player.Inputs.MovementAxes();
        player.PlayerCharacter.Move(movementAxes);
    }
    
    public void Update()
    {
        Interactable interactable = player.InteractablePicker.target;
        bool interact = player.Inputs.InteractDown();
        if (interactable != null && interact) interactable.Interact(player);

        bool inventory = player.Inputs.InventoryDown();
        if (inventory) player.UI.ToggleInventory();

        bool cancel = player.Inputs.CancelDown();
        if (cancel) player.UI.Cancel();
    }
}
