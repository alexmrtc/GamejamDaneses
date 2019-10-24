using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingMenu : MonoBehaviour
{
    public Slider volume;
    public Slider volumeMusic;
    public Slider volumeEffects;
    public AudioMixer audioMixer;


    public void SetVolumeMaster(float volume)
    {
        audioMixer.SetFloat("volumeMaster", volume);
    }

    public void SetVolumeMusic(float volume)
    {
        audioMixer.SetFloat("volumeMusic", volume);
    }

    public void SetVolumeFXs(float volume)
    {
        audioMixer.SetFloat("volumeFxs", volume);
    }

    public void Quality(int index)
    {
        QualitySettings.SetQualityLevel(index);
    }
}
