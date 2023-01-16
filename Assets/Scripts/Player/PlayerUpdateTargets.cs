using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUpdateTargets
{
    public readonly Inputs inputs;
    public readonly PlayerCharacter playerCharacter;

    public PlayerUpdateTargets(Inputs inputs, PlayerCharacter playerCharacter)
    {
        this.inputs = inputs;
        this.playerCharacter = playerCharacter;
    }
}
