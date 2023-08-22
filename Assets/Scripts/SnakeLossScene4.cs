using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnakeLossScene4 : MonoBehaviour
{
    private string LossScene4 = "Loss4";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle" || collision.tag == "ObstacleWall")
        {
            SceneManager.LoadScene(LossScene4);
        }
    }
}
