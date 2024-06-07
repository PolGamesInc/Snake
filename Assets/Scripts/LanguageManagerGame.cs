using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageManagerGame : MonoBehaviour
{
    [SerializeField] private GameObject[] RussianTextObjects;
    [SerializeField] private GameObject[] EnglishTextObjects;

    private void Update()
    {
        if(LanguageManagerMenu.LanguageNumber == 1)
        {
            for(int i = 0; i < RussianTextObjects.Length; i++)
            {
                RussianTextObjects[i].SetActive(true);
            }

            for (int i = 0; i < EnglishTextObjects.Length; i++)
            {
                EnglishTextObjects[i].SetActive(false);
            }
        }
        else if(LanguageManagerMenu.LanguageNumber == 2)
        {
            for (int i = 0; i < EnglishTextObjects.Length; i++)
            {
                EnglishTextObjects[i].SetActive(true);
            }

            for (int i = 0; i < RussianTextObjects.Length; i++)
            {
                RussianTextObjects[i].SetActive(false);
            }
        }
    }
}
