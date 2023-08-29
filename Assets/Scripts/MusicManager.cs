using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    [SerializeField] private Image imageButtonSoundOnOff;
    [SerializeField] private Sprite[] spriteButtonSoundArray;

    [SerializeField] private AudioClip GameMelody;
    [SerializeField] private AudioSource audio;

    public Snake Player;

    private void Start()
    {
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        GameObject[] audioSourceObjs = GameObject.FindGameObjectsWithTag("AudioSourse");
        if (audioSourceObjs.Length > 1)
        {
            for (int i = 1; i < audioSourceObjs.Length; i++)
            {
                Destroy(audioSourceObjs[i]);
            }
        }
    }

    public void OnOffGameMelody()
    {
        if (AudioListener.volume == 1)
        {
            AudioListener.volume = 0;
            imageButtonSoundOnOff.sprite = spriteButtonSoundArray[0];
        }
        else
        {
            AudioListener.volume = 1;
            imageButtonSoundOnOff.sprite = spriteButtonSoundArray[1];
        }
    }
}