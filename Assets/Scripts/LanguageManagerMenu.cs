using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class LanguageManagerMenu : MonoBehaviour
{
    [SerializeField] private Text TextButtonRuOrEn;
    [SerializeField] private Image ButtonRuOrEn;
    public static int LanguageNumber = 1;

    [SerializeField] private GameObject[] RussianTextObjectsMenu;
    [SerializeField] private GameObject[] EnglishTextObjectsMenu;

    [SerializeField] private Sprite RussianFlag;
    [SerializeField] private Sprite AmericanFlag;

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
            ButtonRuOrEn.GetComponent<Image>().sprite = RussianFlag;

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
            ButtonRuOrEn.GetComponent<Image>().sprite = AmericanFlag;

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
