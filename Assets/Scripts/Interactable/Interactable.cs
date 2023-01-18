using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Interactable
{
    public abstract string GetInteractionText();
    public abstract Vector3 GetInteractionPosition();
    public abstract bool Interact(Player player);
}
