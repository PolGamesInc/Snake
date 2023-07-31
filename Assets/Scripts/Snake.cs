using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Snake : MonoBehaviour
{
    private Vector2 _direction = Vector2.zero;
    private int Score;
    private List<Transform> _segments = new List<Transform>();

    [SerializeField] private Transform segmentPrefab;
    [SerializeField] private int initialSize;
    [SerializeField] private Text ScoreText;

    private void Start()
    {
        ResetStay();
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
        for(int i = 1; i <_segments.Count; i++)
        {
            Destroy(_segments[i].gameObject);
        }

        _segments.Clear();
        _segments.Add(this.transform);

        for(int i = 1; i < this.initialSize; i++)
        {
            _segments.Add(Instantiate(this.segmentPrefab));
        }

        Score = 0;

        this.transform.position = Vector3.zero;
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
