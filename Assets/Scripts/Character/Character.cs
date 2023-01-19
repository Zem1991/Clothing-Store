using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    protected Animator animator;
    protected new Rigidbody2D rigidbody2D;

    [Header("Character Data")]
    [SerializeField] public readonly CharacterData characterData;

    [Header("CharacterComponents")]
    [SerializeField] protected CharacterAnimator characterAnimator;
    [SerializeField] protected CharacterMovement characterMovement;

    protected virtual void Awake()
    {
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        characterAnimator = new(this, animator);
        characterMovement = new(this, rigidbody2D);
    }

    public void Move(Vector2 direction)
    {
        characterAnimator.Move(direction);
        characterMovement.Move(direction);
    }
}
