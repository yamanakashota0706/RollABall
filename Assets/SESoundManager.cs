using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SESoundManager : MonoBehaviour
{
    public AudioClip SEAudioClip;

    public AudioSource SEAudioSource;

    public void PlayPickupItemSE()
    {
        SEAudioSource.clip = SEAudioClip;
        SEAudioSource.Play();

    }

}
