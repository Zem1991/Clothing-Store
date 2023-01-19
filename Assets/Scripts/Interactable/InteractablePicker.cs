using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractablePicker
{
    [Header("Settings")]
    [SerializeField] private Player player;

    [Header("Runtime")]
    [SerializeField] private PlayerCharacter playerCharacter;
    [SerializeField] private InteractableHighlight interactableHighlight;
    [SerializeField] public Vector3 position;
    [SerializeField] public Interactable target;

    public InteractablePicker(Player player)
    {
        this.player = player;
        playerCharacter = player.PlayerCharacter;
        interactableHighlight = player.InteractableHighlight;
    }

    public void Pick()
    {
        if (!player.GameState.IsPlayable())
        {
            interactableHighlight.Hide();
            return;
        }

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
