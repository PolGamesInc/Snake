using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeGoodWallLevel2X : MonoBehaviour
{
    [SerializeField] private GameObject[] snakeSegmentsArray;

    private void Update()
    {
        snakeSegmentsArray = GameObject.FindGameObjectsWithTag("Obstacle");
        if (this.gameObject.transform.position.x == -6)
        {
            for (int i = 0; i < snakeSegmentsArray.Length; i++)
            {
                snakeSegmentsArray[i].tag = "SnakeSegments";
                Snake snake = GetComponent<Snake>();
                snake.StatusScripts = false;
                StartCoroutine(AssignSnakeSegments());
            }
            Vector2 posPlayer = this.gameObject.transform.position;
            posPlayer.x = -posPlayer.x - 1f;
            this.gameObject.transform.position = posPlayer;
        }

        if (this.gameObject.transform.position.x == 6)
        {
            for (int i = 0; i < snakeSegmentsArray.Length; i++)
            {
                snakeSegmentsArray[i].tag = "SnakeSegments";
                Snake snake = GetComponent<Snake>();
                snake.StatusScripts = false;
                StartCoroutine(AssignSnakeSegments());
            }
            Vector2 posPlayer = this.gameObject.transform.position;
            posPlayer.x = -posPlayer.x + 1f;
            this.gameObject.transform.position = posPlayer;
        }
    }

    private IEnumerator AssignSnakeSegments()
    {
        yield return new WaitForSeconds(0.1f);
        Snake snake = GetComponent<Snake>();
        snake.StatusScripts = true;
        for (int a = 0; a < snakeSegmentsArray.Length; a++)
        {
            snakeSegmentsArray[a].tag = "Obstacle";
        }
    }
}
