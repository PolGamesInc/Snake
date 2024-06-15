using UnityEngine;

public class Food : MonoBehaviour
{
    [SerializeField] private BoxCollider2D gridArea;
    [SerializeField] private AudioClip SoundSelection;

    [SerializeField] private GameObject Player;

    private void Update()
    {
        for (int i = 0; i < Player.GetComponent<Snake>()._segments.Count; i++)
        {
            if (this.transform.position == Player.GetComponent<Snake>()._segments[i].transform.position)
            {
                RandomazePosition();
                print("RandomazePosition");
            }
        }
    }

    private void Start()
    {
        RandomazePosition();
    }

    private void RandomazePosition()
    {
        Bounds bounds = this.gridArea.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            RandomazePosition();
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.clip = SoundSelection;
            audioSource.Play();
        }
    }
}
