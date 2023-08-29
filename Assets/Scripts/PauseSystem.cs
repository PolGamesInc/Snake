using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseSystem : MonoBehaviour
{
    [SerializeField] private GameObject[] PauseElements;
    [SerializeField] private GameObject[] GameElements;

    [SerializeField] private GameObject Player;

    public Vector2 previousDerection;

    private void Start()
    {
        for (int i = 0; i < PauseElements.Length; i++)
        {
            PauseElements[i].SetActive(false);
        }
    }

    private void Update()
    {
        previousDerection = Player.GetComponent<Snake>()._direction;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameObject[] Obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
            for(int a = 0; a < Obstacles.Length; a++)
            {
                Obstacles[a].tag = "HarmlessSegment";
            }

            Player.GetComponent<Snake>()._direction = Vector2.zero;

            for (int i = 0; i < PauseElements.Length; i++)
            {
                PauseElements[i].SetActive(true);
            }

            for(int b = 0; b < GameElements.Length; b++)
            {
                GameElements[b].SetActive(false);
            }
        }
    }

    public void PauseOn()
    {
        GameObject[] Obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
        for (int a = 0; a < Obstacles.Length; a++)
        {
            Obstacles[a].tag = "HarmlessSegment";
        }

        Player.GetComponent<Snake>()._direction = Vector2.zero;

        for (int i = 0; i < PauseElements.Length; i++)
        {
            PauseElements[i].SetActive(true);
        }

        for (int b = 0; b < GameElements.Length; b++)
        {
            GameElements[b].SetActive(false);
        }
    }

    public void Resume()
    {
        //Player.GetComponent<Snake>()._direction = Vector2.left;
        if (Player.GetComponent<Snake>()._direction != previousDerection)
        {
            Player.GetComponent<Snake>()._direction = previousDerection;
        }

        GameObject[] Obstacles = GameObject.FindGameObjectsWithTag("HarmlessSegment");
        for (int a = 0; a < Obstacles.Length; a++)
        {
            Obstacles[a].tag = "Obstacle";
        }

        for (int i = 0; i < PauseElements.Length; i++)
        {
            PauseElements[i].SetActive(false);
        }

        for (int b = 0; b < GameElements.Length; b++)
        {
            GameElements[b].SetActive(true);
        }
    }
}
