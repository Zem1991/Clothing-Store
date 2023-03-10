using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoor : MonoBehaviour, Interactable
{
    public string GetInteractionText()
    {
        return "Exit Game";
    }

    public Vector3 GetInteractionPosition()
    {
        return transform.position;
    }

    public bool Interact(Player player)
    {
        new ExitGameHandler().Handle();
        return true;
    }
}
