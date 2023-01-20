using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceOneShot : MonoBehaviour
{
    private AudioSource sfxSource;

    public void Play(AudioClip audioClip)
    {
        sfxSource = GetComponent<AudioSource>();
        sfxSource.PlayOneShot(audioClip);
        Destroy(sfxSource.gameObject, audioClip.length);
    }

    public void Stop()
    {
        Destroy(gameObject);
    }

    public bool IsPlaying()
    {
        return sfxSource.isPlaying;
    }
}
