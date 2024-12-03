using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameReadyAPI : MonoBehaviour
{
    public static GameObject sdk;

    public void Start()
    {
        sdk = GameObject.FindGameObjectWithTag("YandexSDK");  
    }

    public static void GameReadyAPIReady()
    {
        sdk.GetComponent<YandexSDK>().OnLoadingAPIReady();
    }

    public static void GameReadyAPIStart()
    {
        sdk.GetComponent<YandexSDK>().OnGameplayAPIStart();
    }

    public static void GameReadyAPIStop()
    {
        sdk.GetComponent<YandexSDK>().OnGameplayAPIStop();
    }
}
