using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellBox : MonoBehaviour, Interactable
{
    public string GetInteractionText()
    {
        return "Sell your Items";
    }

    public Vector3 GetInteractionPosition()
    {
        return transform.position;
    }

    public bool Interact(PlayerCharacter playerCharacter)
    {
        throw new System.NotImplementedException();
    }
}
