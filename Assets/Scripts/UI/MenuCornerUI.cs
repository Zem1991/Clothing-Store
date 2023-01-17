using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCornerUI : GenericUI<Player>
{
    public override void Refresh(Player thing)
    {

    }

    public void ExitGameButton()
    {
        new ExitGameHandler().Handle();
    }
}
