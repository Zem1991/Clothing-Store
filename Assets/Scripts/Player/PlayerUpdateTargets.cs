using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUpdateTargets
{
    public readonly Player player;
    public readonly Camera camera;
    public readonly PlayerCharacter playerCharacter;

    public PlayerUpdateTargets(Player player, Camera camera, PlayerCharacter playerCharacter)
    {
        this.player = player;
        this.camera = camera;
        this.playerCharacter = playerCharacter;
    }
}
