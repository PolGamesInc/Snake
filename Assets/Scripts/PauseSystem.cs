using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class PauseSystem : MonoBehaviour
{
    public GameObject[] PauseElements;
    [SerializeField] private GameObject[] GameElements;

    [SerializeField] private GameObject Player;

    public Vector2 previousDerection;

    private void Start()
    {
        for (int i = 0; i < PauseElements.Length; i++)
        {
            PauseElements[i].SetActive(false);
        }

        for(int a = 0; a < GameElements.Length; a++)
        {
            GameElements[a].SetActive(true);
        }
    }

    private void Update()
    {
        previousDerection = Player.GetComponent<Snake>()._direction;

        if(Input.GetKeyUp(KeyCode.Escape))
        {
            PauseOn();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameObject[] Obstacles = GameObject.FindGameObjectsWithTag("Obstacle");

            for (int e = 0; e < Player.GetComponent<BlockBackMove>().ManagementButtonsFake.Length; e++)
            {
                Player.GetComponent<BlockBackMove>().ManagementButtonsFake[e].SetActive(false);
            }

            for (int a = 0; a < Obstacles.Length; a++)
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
        Snake.MovementArrow = false;

        GameObject[] Obstacles = GameObject.FindGameObjectsWithTag("Obstacle");

        for (int e = 0; e < Player.GetComponent<BlockBackMove>().ManagementButtonsFake.Length; e++)
        {
            Player.GetComponent<BlockBackMove>().ManagementButtonsFake[e].SetActive(false);
        }

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

        Snake.MovementArrow = true;
    }
}
