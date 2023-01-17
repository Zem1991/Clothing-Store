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
        PlayerCharacter playerCharacter = player.PlayerCharacter;
        InteractablePicker interactablePicker = new(playerCharacter);
        interactablePicker.Pick();

        Interactable interactable = interactablePicker.target;
        if (interactable == null) return;

        bool interact = player.Inputs.InteractDown();
        if (interact) interactable.Interact(playerCharacter);
    }
}
