using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SnakeLossScene1 : MonoBehaviour
{
    [SerializeField] private GameObject Player;

    public GameObject[] LossElements;
    [SerializeField] private GameObject[] GameElements;

    [SerializeField] private Text LossTextRussian;
    [SerializeField] private Text LossTextEnglish;

    [DllImport("__Internal")]
    private static extern void ShowFullscreen();

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

            StartCoroutine(WaitAds());

            PauseSystem.PausePermission = false;
        }
    }

    public IEnumerator WaitAds()
    {
        yield return new WaitForSeconds(0.1f);
        ShowFullscreen();
    }
}
