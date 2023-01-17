using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueUI : GenericUI<Player>
{
    public override void Refresh(Player player)
    {
        if (!player)
        {
            Hide();
            return;
        }

        Hide();
    }
}
