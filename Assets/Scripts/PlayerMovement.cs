using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10000f; 

    private Rigidbody2D rb;

    private float range = 0.0f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
    }

    private void Update()
    {
        Vector2 movement = Input.mousePosition;
        movement.x = (Input.mousePosition.x - Screen.width / 2) / Screen.width;
        movement.y = (Input.mousePosition.y - Screen.height / 2) / Screen.height;
        rb.velocity = movement * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("SOLID"))
        {
            rb.velocity = Vector2.zero;
        }
    }
}
