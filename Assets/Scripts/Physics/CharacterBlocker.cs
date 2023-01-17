using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBlocker : MonoBehaviour
{
    private void Start()
    {
        Character character = GetComponentInParent<Character>();
        Collider2D characterCollider = character.GetComponent<Collider2D>();
        Collider2D thisCollider = GetComponent<Collider2D>();
        if (characterCollider != thisCollider)
        {
            Physics2D.IgnoreCollision(characterCollider, thisCollider, true);
        }
    }
}
