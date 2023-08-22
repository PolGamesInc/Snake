using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnakeLossScene6 : MonoBehaviour
{
    private string LossScene6 = "Loss6";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle" || collision.tag == "ObstacleWall")
        {
            SceneManager.LoadScene(LossScene6);
        }
    }
}
