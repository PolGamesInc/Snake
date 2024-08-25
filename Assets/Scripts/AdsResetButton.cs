using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class AdsResetButton : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void ShowFullscreen();

    public void ShowAds()
    {
        ShowFullscreen();
    }
}
