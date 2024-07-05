using System.Runtime.InteropServices;
using UnityEngine;

public class AdsYandex : MonoBehaviour
{
    [DllImport("__Internal")]

    private static extern void ShowFullscreen();

    private void Start()
    {
        ShowFullscreen();
    }
}
