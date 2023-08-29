using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Snake : MonoBehaviour
{
    public Vector2 _direction = Vector2.zero;
    private int Score;
    private List<Transform> _segments = new List<Transform>();
    private string LossScene = "Loss";

    [SerializeField] private Transform segmentPrefab;
    [SerializeField] private int initialSize;
    [SerializeField] private Text ScoreText;

    public bool StatusScripts = true;

    private void Start()
    {
        for (int i = 1; i < _segments.Count; i++)
        {
            Destroy(_segments[i].gameObject);
        }

        _segments.Clear();
        _segments.Add(this.transform);

        for (int i = 1; i < this.initialSize; i++)
        {
            _segments.Add(Instantiate(this.segmentPrefab));
        }

        Score = 0;

        this.transform.position = new Vector2(-4, -4);
    }

    private void Update()
    {
        ScoreText.text = Score.ToString();

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            _direction = Vector2.up;
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            _direction = Vector2.down;
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _direction = Vector2.left;
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            _direction = Vector2.right;
        }

        FindSnakeSigmentsClone();
    }

    private void FixedUpdate()
    {
        for(int i = _segments.Count - 1; i > 0; i--)
        {
            _segments[i].position = _segments[i - 1].position;
        }

        this.transform.position = new Vector3(Mathf.Round(this.transform.position.x) + _direction.x, Mathf.Round(this.transform.position.y) + _direction.y, 0.0f);
    }

    private void Grow()
    {
        Transform segment = Instantiate(this.segmentPrefab);
        segment.position = _segments[_segments.Count - 1].position;

        _segments.Add(segment);
    }

    private void ResetStay()
    {
        Handheld.Vibrate();
        //SceneManager.LoadScene(LossScene);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Food")
        {
            Grow();
            Score += 7;
        }
        else if(collision.tag == "Obstacle")
        {
            ResetStay();
        }

        if(collision.tag == "GoodWallX")
        {
            Vector2 playerPosX = transform.position;
            playerPosX.x = -playerPosX.x;
            transform.position = playerPosX;
        }
        else if(collision.tag == "GoodWallY")
        {
            Vector2 playerPosY = transform.position;
            playerPosY.y = playerPosY.y -= 6;
            transform.position = playerPosY;
        }

        if(collision.tag == "ObstacleWall")
        {
            ResetStay();
        }
    }

    private void FindSnakeSigmentsClone()
    {
        if (StatusScripts == true)
        {
            GameObject[] snakeSegmentsArray = GameObject.FindGameObjectsWithTag("SnakeSegments");
            if (Score >= 7)
            {
                for (int i = 0; i < snakeSegmentsArray.Length; i++)
                {
                    snakeSegmentsArray[i].tag = "Obstacle";
                }
            }
        }
    }

    public void MoveUp()
    {
        _direction = Vector2.up;
    }

    public void MoveDown()
    {
        _direction = Vector2.down;
    }

    public void MoveLeft()
    {
        _direction = Vector2.left;
    }

    public void MoveRight()
    {
        _direction = Vector2.right;
    }
}
