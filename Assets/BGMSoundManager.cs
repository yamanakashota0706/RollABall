using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMSoundManager : MonoBehaviour
{
    public AudioClip BGMAudioClip;

    public AudioClip BGMPlayGameOver;

    public AudioClip BGMPlayGameClear;


    public AudioSource BGMAudioSource;

    private void Start()
    {
        BGMAudioSource.clip = BGMAudioClip;
        BGMAudioSource.Play();
    }

    public void PlayGameOverBGM() {
        BGMAudioSource.clip = BGMPlayGameOver;
        BGMAudioSource.Play();
    }

    public void PlayGameClearBGM()
    {
        BGMAudioSource.clip = BGMPlayGameClear;
        BGMAudioSource.Play();
    }
}
