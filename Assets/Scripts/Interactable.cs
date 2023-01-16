using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Interactable
{
    public abstract string GetInteractionText();
    public abstract bool Interact(PlayerCharacter playerCharacter);
}
