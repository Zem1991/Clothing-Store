using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraUpdater
{
    private Player player;

    public CameraUpdater(Player player)
    {
        this.player = player;
    }

    public void LateUpdate()
    {
        Vector3 position = player.PlayerCharacter.transform.position;
        position.z = -10;
        player.Camera.transform.position = position;
    }
}
