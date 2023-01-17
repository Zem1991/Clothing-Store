using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : Character
{
    [Header("Player CharacterComponents")]
    [SerializeField] protected PlayerCharacterInventory inventory;

    protected override void Awake()
    {
        base.Awake();
        inventory = new(this);
    }

    public Inventory GetInventory() => inventory.GetInventory();
    //public bool Add(Item item) => inventory.Add(item);
}
