using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingMenu : MonoBehaviour
{

    public AudioMixer audioMixer;
    public AudioMixer Music;
    public AudioMixer Sfx;

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("Volume", volume);
        //audioMixer.SetFloat("MusicVol", Mathf.Log10(sliderValue)*20);
    }
    public void SetMusic(float volume)
    {
        Music.SetFloat("Music", volume);
    }
    public void SetSfx(float volume)
    {
        Sfx.SetFloat("Sfx", volume);
    }

}
