using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    public Image imageButtonSoundOnOff;
    public Sprite[] spriteButtonSoundArray;

    [SerializeField] private AudioClip GameMelody;
    [SerializeField] private AudioSource audio;

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
}