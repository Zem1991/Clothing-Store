using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractablePicker
{
    [Header("Settings")]
    [SerializeField] private PlayerCharacter playerCharacter;
    [SerializeField] private InteractableHighlight interactableHighlight;

    [Header("Runtime")]
    [SerializeField] public Vector3 position;
    [SerializeField] public Interactable target;

    public InteractablePicker(PlayerCharacter playerCharacter, InteractableHighlight interactableHighlight)
    {
        this.playerCharacter = playerCharacter;
        this.interactableHighlight = interactableHighlight;
    }

    public void Pick()
    {
        Vector3 findPos = playerCharacter.transform.position;
        InteractableFinder finder = new();
        target = finder.OverlapSphere(findPos);
        if (target != null)
        {
            position = target.GetInteractionPosition();
            interactableHighlight.Show(position);
        }
        else
        {
            interactableHighlight.Hide();
        }
    }
}
