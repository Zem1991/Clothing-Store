using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerCharacterInventory : CharacterComponent
{
    [SerializeField] private Inventory inventory;

    public PlayerCharacterInventory(Character character) : base(character)
    {
        inventory = new();
    }

    public bool Add(Item item) => inventory.Add(item);
}
