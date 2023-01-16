using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterComponent
{
    protected Character character;

    protected CharacterComponent(Character character)
    {
        this.character = character;
    }
}
