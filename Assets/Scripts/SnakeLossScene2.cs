using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnakeLossScene2 : MonoBehaviour
{
    private string LossScene2 = "Loss2";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle" || collision.tag == "ObstacleWall")
        {
            SceneManager.LoadScene(LossScene2);
        }
    }
}
