using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnakeLossScene5 : MonoBehaviour
{
    private string LossScene5 = "Loss5";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle" || collision.tag == "ObstacleWall")
        {
            SceneManager.LoadScene(LossScene5);
        }
    }
}
