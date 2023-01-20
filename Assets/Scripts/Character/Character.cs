using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Character : MonoBehaviour
{
    protected List<Animator> animators;
    protected new Rigidbody2D rigidbody2D;

    [Header("Character Data")]
    [SerializeField] public CharacterData characterData;

    [Header("CharacterComponents")]
    [SerializeField] protected CharacterAnimator characterAnimator;
    [SerializeField] protected CharacterMovement characterMovement;

    protected virtual void Awake()
    {
        animators = GetComponentsInChildren<Animator>().ToList();
        rigidbody2D = GetComponent<Rigidbody2D>();
        characterAnimator = new(this, animators);
        characterMovement = new(this, rigidbody2D);
    }

    public void Move(Vector2 direction)
    {
        characterAnimator.Move(direction);
        characterMovement.Move(direction);
    }
}
