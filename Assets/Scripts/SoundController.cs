using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public static SoundController instance;
    public AudioSource BGM, Effect, Effectbgm;//Effectbgm is for Jump,Effect is for True and False button

    public AudioClip[] EffectList, BGMList, Effectbgmlist;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Use this for initialization
    void Start()
    {
    }

    public void ToggleVolume()
    {
        if (BGM.volume > 0)
        {
            BGM.volume = 0;
            Effectbgm.volume = 0;
            Effect.volume = 0;
        }
        else
        {
            BGM.volume = 1;
            Effect.volume = 1;
            Effectbgm.volume = 1;
        }
    }

    public void PlayEffectSound(int index)
    {
        Effect.clip = EffectList[index];
        Effect.Play();
    }
    public void PlayEffectbgmSound(int index)
    {
        Effectbgm.clip = Effectbgmlist[index];
        Effectbgm.Play();
    }
    public void PlaybgmSound(int index)
    {
        BGM.clip = BGMList[index];
        BGM.Play();
    }
}