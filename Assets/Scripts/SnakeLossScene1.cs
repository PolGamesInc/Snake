using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SnakeLossScene1 : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void ShowFullscreen();

    [SerializeField] private GameObject Player;

    public GameObject[] LossElements;
    [SerializeField] private GameObject[] GameElements;

    [SerializeField] private Text LossTextRussian;
    [SerializeField] private Text LossTextEnglish;

    [SerializeField] private GameObject AudioSourse;

    [SerializeField] private float SecondForAds;
    private bool PermissionAds = false;

    [SerializeField] private Text TimeForAds;
    [SerializeField] private GameObject TimeForAdsText;
    [SerializeField] private GameObject ShowFullScreenFor;

    private bool ShowTextForAdsTime;

    private void Start()
    {
        for (int i = 0; i < LossElements.Length; i++)
        {
            LossElements[i].SetActive(false);
        }

        for (int i = 0; i < GameElements.Length; i++)
        {
            GameElements[i].SetActive(true);
        }
        TimeForAdsText.SetActive(false);
        ShowFullScreenFor.SetActive(false);

        ShowTextForAdsTime = false;
        StartCoroutine(WaitShowTextForAds());
    }

    private void FixedUpdate()
    {
        if (PermissionAds == true)
        {
            SecondForAds -= 1 * Time.deltaTime;
        }
        else if(PermissionAds == false)
        {
            SecondForAds = 3;
        }

        TimeForAds.text = SecondForAds.ToString();
    }

    private void Update()
    {
        if(SecondForAds <= 0)
        {
            PermissionAds = false;
            TimeForAdsText.SetActive(false);
            ShowFullScreenFor.SetActive(false);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (LanguageManagerMenu.LanguageNumber == 2)
        {
            LossTextRussian.text = "";
            LossElements[0].SetActive(false);
        }

        if (LanguageManagerMenu.LanguageNumber == 1)
        {
            LossTextEnglish.text = "";
            LossElements[4].SetActive(false);
        }

        if (collision.tag == "Obstacle" || collision.tag == "ObstacleWall")
        {
            Player.GetComponent<Snake>().Start();
            Player.GetComponent<Snake>()._direction = Vector2.zero;

            for (int i = 0; i < LossElements.Length; i++)
            {
                LossElements[i].SetActive(true);
            }

            for (int i = 0; i < GameElements.Length; i++)
            {
                GameElements[i].SetActive(false);
            }

            for (int e = 0; e < Player.GetComponent<BlockBackMove>().ManagementButtonsFake.Length; e++)
            {
                Player.GetComponent<BlockBackMove>().ManagementButtonsFake[e].SetActive(false);
            }

            Snake.MovementUp = false;
            Snake.MovementDown = false;
            Snake.MovementRight = false;
            Snake.MovementLeft = false;

            AudioSourse.GetComponent<MusicManager>().OffMelodyAds();

            PauseSystem.PausePermission = false;

            StartCoroutine(WaitGameReadyAPIStop());

            if (ShowTextForAdsTime == true)
            {
                TimeForAdsText.SetActive(true);
                ShowFullScreenFor.SetActive(true);
            }

            PermissionAds = true;
            StartCoroutine(WaitAds());
        }
    }

    public IEnumerator WaitGameReadyAPIStop()
    {
        yield return new WaitForSeconds(0.1f);
        GameReadyAPI.GameReadyAPIStop();
        print("GameReaduAPIStop");
    }

    public IEnumerator WaitAds()
    {
        yield return new WaitForSeconds(3f);
        ShowFullscreen();
    }

    private IEnumerator WaitShowTextForAds()
    {
        yield return new WaitForSeconds(60f);
        ShowTextForAdsTime = true;
    }
}
