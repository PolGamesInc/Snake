using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnakeLossScene1 : MonoBehaviour
{
    //private string LossScene = "Loss";
    [SerializeField] private GameObject Player;

    [SerializeField] private GameObject[] LossElements;
    [SerializeField] private GameObject[] GameElements;

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
            //SceneManager.LoadScene(LossScene);
        }
    }
}
