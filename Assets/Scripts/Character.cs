using System;
using UnityEngine;

public class Character : MonoBehaviour
{
    public static event EventHandler OnPlayerDeath;
    public static event EventHandler OnGameWon;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            OnPlayerDeath?.Invoke(this, EventArgs.Empty);
        }
        else if (collision.gameObject.CompareTag("Exit"))
        {
            Debug.Log("Game Won");
            OnGameWon?.Invoke(this, EventArgs.Empty);
        }
    }
}
