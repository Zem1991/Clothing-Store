using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Inputs
{
    [Header("Movement")]
    [SerializeField] private string movementX = "Horizontal";
    [SerializeField] private string movementY = "Vertical";

    [Header("Other")]
    [SerializeField] private KeyCode interact = KeyCode.E;
    [SerializeField] private KeyCode inventory = KeyCode.I;
    [SerializeField] private KeyCode cancel = KeyCode.Escape;

    public Vector2 MovementAxes()
    {
        Vector2 result = new()
        {
            x = Input.GetAxisRaw(movementX),
            y = Input.GetAxisRaw(movementY)
        };
        result.Normalize();
        return result;
    }

    public bool InteractDown()
    {
        return Input.GetKeyDown(interact);
    }

    public bool InventoryDown()
    {
        return Input.GetKeyDown(inventory);
    }

    public bool CancelDown()
    {
        return Input.GetKeyDown(cancel);
    }
}
