using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mannequin : MonoBehaviour, Interactable
{
    public string GetInteractionText()
    {
        return $"Buy THING that costs AMOUNT";
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
