using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CharacterAnimator : CharacterComponent
{
    protected Animator animator;

    public CharacterAnimator(Character character, Animator animator) : base(character)
    {
        this.animator = animator;
    }
    
    public void Move(Vector2 direction)
    {
        float speed = direction.magnitude;
        if (speed <= 0) return;
        animator.SetFloat("Horizontal", direction.x);
        animator.SetFloat("Vertical", direction.y);
        animator.SetFloat("Speed", speed);
    }
}
