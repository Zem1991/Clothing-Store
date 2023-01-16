using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CharacterMovement : CharacterComponent
{
    protected Rigidbody2D rigidbody2D;

    [Header("Settings")]
    [SerializeField] private float moveSpeed = 10F;

    public CharacterMovement(Character character, Rigidbody2D rigidbody2D) : base(character)
    {
        this.rigidbody2D = rigidbody2D;
    }
    
    public void Move(Vector2 direction)
    {
        //Look(direction);
        Vector2 position = rigidbody2D.position;
        Vector2 speed = direction * moveSpeed * Time.fixedDeltaTime;
        rigidbody2D.MovePosition(position + speed);
        //rigidbody2D.AddForce(speed, ForceMode2D.Impulse);
    }

    //public void Look(Vector2 direction)
    //{
    //    Vector2 position = character.transform.position + direction;
    //    character.transform.LookAt(position);
    //}
}
