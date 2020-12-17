using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class click : MonoBehaviour
{
    public AudioSource sfx;
    public AudioClip clickFx;

    public void ClickSound()
    {
        sfx.PlayOneShot(clickFx);
    }
}
