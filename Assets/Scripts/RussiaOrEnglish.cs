using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RussiaOrEnglish : MonoBehaviour
{
    [SerializeField] private Text TextButtonRuOrEn;
    private int LanguageNumber;

    private void Start()
    {
        LanguageNumber = 1;
    }

    private void Update()
    {
        if(LanguageNumber == 1)
        {
            TextButtonRuOrEn.text = "EN";
        }
        else if(LanguageNumber == 2)
        {
            TextButtonRuOrEn.text = "аг";
        }
    }

    public void SwitchLanguage()
    {
        LanguageNumber++;

        if(LanguageNumber == 3)
        {
            LanguageNumber = 1;
        }
    }
}
