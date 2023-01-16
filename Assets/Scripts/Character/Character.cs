using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    protected new Rigidbody2D rigidbody2D;

    [Header("CharacterComponents")]
    [SerializeField] protected CharacterMovement movement;

    protected virtual void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        movement = new(this, rigidbody2D);
    }

    public void Move(Vector2 direction) => movement.Move(direction);
}
