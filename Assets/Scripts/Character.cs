
using System.Collections;
using System.Collections.Generic;


using UnityEngine;

public class Character : MonoBehaviour
{

    public GameObject GameOverUI;
    public GameObject LevelLoader;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {

            Debug.Log("Collided with Finish");
            GameOverUI.GetComponent<GameOverUI>().Show();
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            Debug.Log("Collided with Finish");
            LevelLoader.GetComponent<LevelLoader>().NextLevelLoad();

        }
    }
}
