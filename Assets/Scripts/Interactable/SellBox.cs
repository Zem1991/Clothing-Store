using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellBox : MonoBehaviour, Interactable
{
    public string GetInteractionText()
    {
        return "Sell your backpack items";
    }

    public Vector3 GetInteractionPosition()
    {
        return transform.position;
    }

    public bool Interact(Player player)
    {
        player.UI.ToggleSellFromBackpack(player);
        return true;
    }
}
