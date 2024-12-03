using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class AdsInMenu : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void ShowFullscreen();

    private static int CountShowADS = 0;

    private void Start()
    {
        if (CountShowADS == 0)
        {
            StartCoroutine(WaitAds());
        }
        StartCoroutine(WaitGameReadyAPIReady());
        CountShowADS += 1;
    }

    public IEnumerator WaitAds()
    {
        yield return new WaitForSeconds(0.25f);
        ShowFullscreen();
    }

    public IEnumerator WaitGameReadyAPIReady()
    {
        if (CountShowADS == 0)
        {
            yield return new WaitForSeconds(0.3f);
            GameReadyAPI.GameReadyAPIReady();
            print("GameReadyAPIReadyPrint");
        }
        else
        {
            print("stop");
        }
    }
}
