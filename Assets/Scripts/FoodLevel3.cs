using System.Collections;
using UnityEngine;

public class FoodLevel3 : MonoBehaviour
{
    [SerializeField] private BoxCollider2D gridAreaOne;
    [SerializeField] private BoxCollider2D gridAreaTwo;
    [SerializeField] private BoxCollider2D gridAreaFree;
    [SerializeField] private BoxCollider2D gridAreaFour;

    [SerializeField] private int numberGridArea;

    private void Start()
    {
        RandomazePositionOne();
        RandomazePositionTwo();
        RandomazePositionFree();
    }

    private void Update()
    {
        if (numberGridArea == 1)
        {
            print(numberGridArea);
        }

        if (numberGridArea == 2)
        {
            print(numberGridArea);
        }

        if (numberGridArea == 3)
        {
            print(numberGridArea);
        }

        if (numberGridArea == 4)
        {
            print(numberGridArea);
        }
    }

    private void RandomazePositionOne()
    {
        Bounds boundsGridAreaOne = this.gridAreaOne.bounds;

        float x = Random.Range(boundsGridAreaOne.min.x, boundsGridAreaOne.max.x);
        float y = Random.Range(boundsGridAreaOne.min.y, boundsGridAreaOne.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }

    private void RandomazePositionTwo()
    {
        Bounds boundsGridAreaTwo = this.gridAreaTwo.bounds;

        float x = Random.Range(boundsGridAreaTwo.min.x, boundsGridAreaTwo.max.x);
        float y = Random.Range(boundsGridAreaTwo.min.y, boundsGridAreaTwo.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }

    private void RandomazePositionFree()
    {
        Bounds boundsGridAreaFree = this.gridAreaFree.bounds;

        float x = Random.Range(boundsGridAreaFree.min.x, boundsGridAreaFree.max.x);
        float y = Random.Range(boundsGridAreaFree.min.y, boundsGridAreaFree.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }

    private void RandomazePositionFour()
    {
        Bounds boundsGridAreaFour = this.gridAreaFour.bounds;

        float x = Random.Range(boundsGridAreaFour.min.x, boundsGridAreaFour.max.x);
        float y = Random.Range(boundsGridAreaFour.min.y, boundsGridAreaFour.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            numberGridArea = Random.Range(0, 5);
            StartCoroutine(numberGridAreaNull());
            if(numberGridArea == 1)
            {
                RandomazePositionOne();
            }

            if (numberGridArea == 2)
            {
                RandomazePositionTwo();
            }

            if(numberGridArea == 3)
            {
                RandomazePositionFree();
            }

            if (numberGridArea == 4)
            {
                RandomazePositionFour();
            }
        }
    }

    private IEnumerator numberGridAreaNull()
    {
      yield return new WaitForSeconds(0.1f);
      numberGridArea = 0;
    }
}
