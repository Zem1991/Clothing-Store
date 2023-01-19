using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemSoundEffects : AbstractSingleton<SystemSoundEffects>
{
    [SerializeField] private AudioClip confirmAction;
    [SerializeField] private AudioClip cancelAction;
    [SerializeField] private AudioClip moneyTransaction;

    public AudioClip ConfirmAction { get => confirmAction; private set => confirmAction = value; }
    public AudioClip CancelAction { get => cancelAction; private set => cancelAction = value; }
    public AudioClip MoneyTransaction { get => moneyTransaction; private set => moneyTransaction = value; }
}
