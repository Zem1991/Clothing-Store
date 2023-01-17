using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractablePicker
{
    [Header("Settings")]
    [SerializeField] private PlayerCharacter playerCharacter;

    [Header("Runtime")]
    [SerializeField] public Vector3 position;
    [SerializeField] public Interactable target;

    public InteractablePicker(PlayerCharacter playerCharacter)
    {
        this.playerCharacter = playerCharacter;
    }

    public void Pick()
    {
        Vector3 findPos = playerCharacter.transform.position;
        float radius = 2F;
        InteractableFinder finder = new();
        target = finder.OverlapSphere(findPos, radius);
        if (target != null) position = target.GetInteractionPosition();
    }
}
