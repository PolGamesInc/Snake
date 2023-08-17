using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodWallY : MonoBehaviour
{
    [SerializeField] Transform playerTransform;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Vector2 posPlayer = playerTransform.transform.position;
            posPlayer.y = -posPlayer.y + 7;
            playerTransform.transform.position = posPlayer;
        }
    }
}
