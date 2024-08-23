using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageManagerMenu : MonoBehaviour
{
    [SerializeField] private Text TextButtonRuOrEn;
    public static int LanguageNumber = 1;

    [SerializeField] private GameObject[] RussianTextObjectsMenu;
    [SerializeField] private GameObject[] EnglishTextObjectsMenu;

    private void Start()
    {
        for (int i = 0; i < EnglishTextObjectsMenu.Length; i++)
        {
            EnglishTextObjectsMenu[i].SetActive(false);
        }

        for (int i = 0; i < RussianTextObjectsMenu.Length; i++)
        {
            RussianTextObjectsMenu[i].SetActive(true);
        }
    }

    private void Update()
    {
        if (LanguageNumber == 1)
        {
            TextButtonRuOrEn.text = "аг";

            for (int i = 0; i < RussianTextObjectsMenu.Length; i++)
            {
                RussianTextObjectsMenu[i].SetActive(true);
            }

            for (int i = 0; i < EnglishTextObjectsMenu.Length; i++)
            {
                EnglishTextObjectsMenu[i].SetActive(false);
            }
        }

        else if (LanguageNumber == 2)
        {
            TextButtonRuOrEn.text = "EN";

            for (int i = 0; i < EnglishTextObjectsMenu.Length; i++)
            {
                EnglishTextObjectsMenu[i].SetActive(true);
            }

            for (int i = 0; i < RussianTextObjectsMenu.Length; i++)
            {
                RussianTextObjectsMenu[i].SetActive(false);
            }
        }
    }

    public void SwitchLanguage()
    {
        LanguageNumber++;

        if (LanguageNumber == 3)
        {
            LanguageNumber = 1;
        }
    }
}
