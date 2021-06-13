using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Audio : MonoBehaviour
{
    [SerializeField]
    AudioMixer mixer;

    void Update()
    {
        float vol = (OptionManager.volume * 100) - 50;
        mixer.SetFloat("Volume", vol);
    }
}
