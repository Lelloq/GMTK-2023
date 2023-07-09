using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCollision : MonoBehaviour
{
    private void Start()
    {
        GameObject[] obstacles;
        obstacles = GameObject.FindGameObjectsWithTag("ObstacleVisuals");
        foreach (var obstacle in obstacles) 
        {
            obstacle.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle")) 
        {
            collision.transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            collision.transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}
