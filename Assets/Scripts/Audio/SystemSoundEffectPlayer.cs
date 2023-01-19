using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemSoundEffectPlayer
{
    public void ConfirmAction() => Play(SystemSoundEffects.Instance.ConfirmAction);
    public void CancelAction() => Play(SystemSoundEffects.Instance.CancelAction);
    public void MoneyTransaction() => Play(SystemSoundEffects.Instance.MoneyTransaction);

    private void Play(AudioClip audioClip) => new SoundEffectPlayer(audioClip).Play();
}
