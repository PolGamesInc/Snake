using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageManagerGame : MonoBehaviour
{
    [SerializeField] private GameObject[] RussianTextObjects;
    [SerializeField] private GameObject[] EnglishTextObjects;

    [SerializeField] private Text ShowFullScreenFor;

    private void Update()
    {
        if (LanguageManagerMenu.LanguageNumber == 1)
        {
            ShowFullScreenFor.text = "До рекламы:";

            for (int i = 0; i < RussianTextObjects.Length; i++)
            {
                RussianTextObjects[i].SetActive(true);
            }

            for (int i = 0; i < EnglishTextObjects.Length; i++)
            {
                EnglishTextObjects[i].SetActive(false);
            }
        }
        else if (LanguageManagerMenu.LanguageNumber == 2)
        {
            ShowFullScreenFor.text = "Before AD:";

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
