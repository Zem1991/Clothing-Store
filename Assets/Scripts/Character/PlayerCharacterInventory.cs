using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerCharacterInventory : CharacterComponent
{
    [SerializeField] private Inventory inventory;

    public PlayerCharacterInventory(Character character, CharacterAnimator characterAnimator) : base(character)
    {
        inventory = new(characterAnimator);
    }

    public Inventory GetInventory() => inventory;
}
