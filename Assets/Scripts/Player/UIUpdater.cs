using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIUpdater
{
    //private UI ui;
    //private PlayerUpdateTargets playerUpdateTargets;
    private Player player;

    public UIUpdater(Player player)
    {
        this.player = player;
    }

    //public UIUpdater(UI ui, PlayerUpdateTargets playerUpdateTargets)
    //{
    //    this.ui = ui;
    //    this.playerUpdateTargets = playerUpdateTargets;
    //}

    public void LateUpdate()
    {
        player.UI.Refresh(player);
        //Vector2 movementAxes = playerUpdateTargets.inputs.MovementAxes();
        //playerUpdateTargets.playerCharacter.Move(movementAxes);
    }
}
