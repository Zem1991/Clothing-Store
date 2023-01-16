using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputUpdater
{
    private PlayerUpdateTargets playerUpdateTargets;

    public InputUpdater(PlayerUpdateTargets playerUpdateTargets)
    {
        this.playerUpdateTargets = playerUpdateTargets;
    }

    public void FixedUpdate()
    {
        Vector2 movementAxes = playerUpdateTargets.inputs.MovementAxes();
        playerUpdateTargets.playerCharacter.Move(movementAxes);
    }
}
