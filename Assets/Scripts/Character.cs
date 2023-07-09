using System;
using UnityEngine;

public class Character : MonoBehaviour
{
    public static event EventHandler OnPlayerDeath;
    public static event EventHandler<OnPlayerCollectArgs> OnPlayerCollect;

    public class OnPlayerCollectArgs : EventArgs
    {
        public Items ItemType { get; set; }
    }

    public enum Items 
    {
        Dynamite,
        Topaz,
        Diamond
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            // Player collided with spike
            OnPlayerDeath?.Invoke(this, EventArgs.Empty);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 14) 
        {
            OnPlayerCollect?.Invoke(this, new OnPlayerCollectArgs() {ItemType = Enum.Parse<Items>(collision.tag)});
        }
    }
}
