using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBackMove : MonoBehaviour
{
    [SerializeField] private GameObject Player;

    //[SerializeField] private GameObject[] ManagementButtons;
    [SerializeField] private GameObject[] ManagementButtonsFake;

    private void Update()
    {
        if(Player.GetComponent<Snake>()._direction == Vector2.up)
        {
            ManagementButtonsFake[1].SetActive(true);
            ManagementButtonsFake[2].SetActive(false);
            ManagementButtonsFake[3].SetActive(false);
            ManagementButtonsFake[0].SetActive(false);
        }

        if (Player.GetComponent<Snake>()._direction == Vector2.right)
        {
            ManagementButtonsFake[3].SetActive(true);
            ManagementButtonsFake[1].SetActive(false);
            ManagementButtonsFake[2].SetActive(false);
            ManagementButtonsFake[0].SetActive(false);
        }

        if(Player.GetComponent<Snake>()._direction == Vector2.left)
        {
            ManagementButtonsFake[2].SetActive(true);
            ManagementButtonsFake[1].SetActive(false);
            ManagementButtonsFake[3].SetActive(false);
            ManagementButtonsFake[0].SetActive(false);
        }

        if(Player.GetComponent<Snake>()._direction == Vector2.down)
        {
            ManagementButtonsFake[0].SetActive(true);
            ManagementButtonsFake[2].SetActive(false);
            ManagementButtonsFake[1].SetActive(false);
            ManagementButtonsFake[3].SetActive(false);
        }
    }
}
