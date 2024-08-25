using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class AdsInMenu : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void ShowFullscreen();

    private void Start()
    {
        StartCoroutine(WaitAds());
    }

    public IEnumerator WaitAds()
    {
        yield return new WaitForSeconds(0.25f);
        ShowFullscreen();
    }
}
