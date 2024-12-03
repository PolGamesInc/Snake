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

    public static bool PausePermission = true;

    private void Start()
    {
        PausePermission = true;

        for (int i = 0; i < PauseElements.Length; i++)
        {
            PauseElements[i].SetActive(false);
        }

        for (int a = 0; a < GameElements.Length; a++)
        {
            GameElements[a].SetActive(true);
        }
    }

    private void Update()
    {
        previousDerection = Player.GetComponent<Snake>()._direction;

        if (PausePermission == true)
        {
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                PauseOn();
            }
        }
    }

    public void PauseOn()
    {
        Snake.MovementUp = false;
        Snake.MovementDown = false;
        Snake.MovementRight = false;
        Snake.MovementLeft = false;

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

        StartCoroutine(WaitGameReadyAPIStop());
    }

    public void Resume()
    {
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

        Snake.MovementUp = true;
        Snake.MovementDown = true;
        Snake.MovementRight = true;
        Snake.MovementLeft = true;

        PausePermission = true;

        StartCoroutine(WaitGameReadyAPIStart());
    }

    public IEnumerator WaitGameReadyAPIStart()
    {
        yield return new WaitForSeconds(0.1f);
        GameReadyAPI.GameReadyAPIStart();
        print("GameReaduAPIStart");
    }

    public IEnumerator WaitGameReadyAPIStop()
    {
        yield return new WaitForSeconds(0.1f);
        GameReadyAPI.GameReadyAPIStop();
        print("GameReaduAPIStop");
    }
}