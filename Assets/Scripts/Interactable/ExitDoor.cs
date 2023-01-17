using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoor : MonoBehaviour, Interactable
{
    public string GetInteractionText()
    {
        throw new System.NotImplementedException();
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
