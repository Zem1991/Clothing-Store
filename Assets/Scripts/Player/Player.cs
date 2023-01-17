using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private Inputs inputs;
    [SerializeField] private int money = 100;
    public Inputs Inputs { get => inputs; private set => inputs = value; }
    public int Money { get => money; private set => money = value; }

    [Header("Runtime")]
    [SerializeField] private UI ui;
    [SerializeField] private new Camera camera;
    [SerializeField] private PlayerCharacter playerCharacter;
    [SerializeField] private InteractablePicker interactablePicker;
    public UI UI { get => ui; private set => ui = value; }
    public Camera Camera { get => camera; private set => camera = value; }
    public PlayerCharacter PlayerCharacter { get => playerCharacter; private set => playerCharacter = value; }
    public InteractablePicker InteractablePicker { get => interactablePicker; private set => interactablePicker = value; }

    private void Awake()
    {
        UI = FindObjectOfType<UI>();
        Camera = FindObjectOfType<Camera>();
        PlayerCharacter = FindObjectOfType<PlayerCharacter>();
        InteractablePicker = null;
    }

    private void FixedUpdate()
    {
        InputUpdater inputUpdater = new(this);
        inputUpdater.FixedUpdate();
    }

    private void Update()
    {
        InteractablePicker = new(PlayerCharacter);
        InteractablePicker.Pick();

        InputUpdater inputUpdater = new(this);
        inputUpdater.Update();
    }

    private void LateUpdate()
    {
        CameraUpdater cameraUpdater = new(this);
        cameraUpdater.LateUpdate();

        UIUpdater inputUpdater = new(this);
        inputUpdater.LateUpdate();
    }

    //private PlayerUpdateTargets GetPlayerUpdateTargets()
    //{
    //    return new(this, camera, playerCharacter);
    //}
}
