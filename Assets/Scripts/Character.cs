using UnityEngine;

public class Character : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Spike spike))
        {
            // Player collided with spike
            GameManager.Instance.GameOver();

        }
    }
}
