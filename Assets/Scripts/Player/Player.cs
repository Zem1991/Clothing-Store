using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private Inputs inputs;
    [SerializeField] private int money = 100;

    [Header("Runtime")]
    [SerializeField] private PlayerCharacter playerCharacter;

    private void Awake()
    {
        playerCharacter = FindObjectOfType<PlayerCharacter>();
    }

    private void FixedUpdate()
    {
        InputUpdater inputUpdater = new(GetPlayerUpdateTargets());
        inputUpdater.FixedUpdate();
    }

    //private void LateUpdate()
    //{
    //    InputUpdater inputUpdater = new(this, inputs, GetInputTargets());
    //    inputUpdater.LateUpdate();
    //    UIUpdater uiUpdater = new(this, inputs, GetInputTargets());
    //    uiUpdater.LateUpdate();
    //    LateUpdateExtras();
    //}

    private PlayerUpdateTargets GetPlayerUpdateTargets()
    {
        return new(inputs, playerCharacter);
    }
}
