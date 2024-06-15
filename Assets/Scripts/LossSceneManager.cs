using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LossSceneManager : MonoBehaviour
{
    private string LossScene2 = "Loss2";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
        {
            SceneManager.LoadScene(LossScene2);
        }
    }
}
