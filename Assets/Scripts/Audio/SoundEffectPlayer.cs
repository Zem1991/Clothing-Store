using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectPlayer
{
    private AudioClip audioClip;
    private AudioSourceOneShot source;

    //public SoundEffectPlayer(AudioSource sfxSource, AudioClip audioClip)
    public SoundEffectPlayer(AudioClip audioClip)
    {
        //this.sfxSource = sfxSource;
        this.audioClip = audioClip;
    }

    public AudioSourceOneShot Play()
    {
        AudioSourceOneShot prefab = AllPrefabs.Instance.AudioSourceOneShot;
        source = Object.Instantiate(prefab);
        source.Play(audioClip);
        return source;
    }

    public void Stop()
    {
        source.Stop();
    }

    public bool IsPlaying()
    {
        return source != null && source.IsPlaying();
    }
}
