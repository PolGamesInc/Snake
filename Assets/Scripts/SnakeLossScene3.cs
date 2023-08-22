using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnakeLossScene3 : MonoBehaviour
{
    private string LossScene3 = "Loss3";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle" || collision.tag == "ObstacleWall")
        {
            SceneManager.LoadScene(LossScene3);
        }
    }
}
