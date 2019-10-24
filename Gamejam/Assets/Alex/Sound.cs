using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound
{
    public string name;

    public AudioClip clip;

    public AudioMixerGroup mixer;

    [Range(0f, 1)]
    public float volume;
    [Range(.1f, 3)]
    public float pitch;

    public bool loop;

    [HideInInspector]
    public AudioSource source;

}
 