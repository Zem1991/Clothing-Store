using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectPlayer
{
    private AudioSource sfxSource;
    private AudioClip audioClip;

    //public SoundEffectPlayer(AudioSource sfxSource, AudioClip audioClip)
    public SoundEffectPlayer(AudioClip audioClip)
    {
        //this.sfxSource = sfxSource;
        this.audioClip = audioClip;
    }

    public void Play()
    {
        sfxSource = Object.FindObjectOfType<AudioSource>();
        sfxSource.PlayOneShot(audioClip);
    }

    public void Stop()
    {
        sfxSource.Stop();
    }

    public bool IsPlaying()
    {
        return sfxSource.isPlaying;
    }
}
