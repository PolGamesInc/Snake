using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    public Image imageButtonSoundOnOff;
    public Sprite[] spriteButtonSoundArray;

    [SerializeField] private AudioClip GameMelody;
    public AudioSource audio;

    public static bool StatusSpriteSoundButton = true;

    private void Update()
    {
        if (StatusSpriteSoundButton == false)
        {
            imageButtonSoundOnOff.sprite = spriteButtonSoundArray[0];
        }
    }

    public void OnOffGameMelody()
    {
        if (AudioListener.volume == 1)
        {
            AudioListener.volume = 0;
            StatusSpriteSoundButton = false;
            imageButtonSoundOnOff.sprite = spriteButtonSoundArray[0];
        }
        else
        {
            AudioListener.volume = 1;
            StatusSpriteSoundButton = true;
            imageButtonSoundOnOff.sprite = spriteButtonSoundArray[1];
        }
    }

    public void OffMelodyAds()
    {
        audio.Pause();
    }

    public void OnMelodyAds()
    {
        audio.UnPause();
    }

    private void OnApplicationFocus(bool hasFocus)
    {
        Silence(!hasFocus);
    }

    private void OnApplicationPause(bool isPaused)
    {
        Silence(isPaused);
    }

    private void Silence(bool silence)
    {
        AudioListener.pause = silence;
    }
}