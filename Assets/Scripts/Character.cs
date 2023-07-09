using System;
using UnityEngine;

public class Character : MonoBehaviour
{
    public static event EventHandler OnPlayerDeath;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Spike spike))
        {
            // Player collided with spike
            OnPlayerDeath?.Invoke(this, EventArgs.Empty);
        }
    }
}
