using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SnakeLossScene1 : MonoBehaviour
{
    //private string LossScene = "Loss";
    [SerializeField] private GameObject Player;

    public GameObject[] LossElements;
    [SerializeField] private GameObject[] GameElements;

    [SerializeField] private Text LossTextRussian;
    [SerializeField] private Text LossTextEnglish;

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

    private void OnTriggerEnter2D(Collider2D collision)
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

            for(int i = 0; i < LossElements.Length; i++)
            {
                LossElements[i].SetActive(true);
            }

            for(int i = 0;i < GameElements.Length; i++)
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

            StartCoroutine(WaitShowFullScreen());
            //SceneManager.LoadScene(LossScene);
        }
    }

    private IEnumerator WaitShowFullScreen()
    {
        yield return new WaitForSeconds(1f);
        Player.GetComponent<Fullscreen>().ShowFullScreenAdd();
        print("Show add");
    }   
}
