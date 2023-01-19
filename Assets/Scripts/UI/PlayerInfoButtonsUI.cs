using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfoButtonsUI : GenericUI<Player>
{
    public override void Refresh(Player thing)
    {
        if (thing.GameState.IsPlayable()) Show();
        else Hide();
    }
}
