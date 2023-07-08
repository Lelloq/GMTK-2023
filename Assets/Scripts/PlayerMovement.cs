using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5000f; 

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
    }

    private void FixedUpdate()
    {
        Vector2 movement = Input.mousePosition;
        movement.x = (Input.mousePosition.x - Screen.width / 2) / Screen.width * 2f;
        movement.y = (Input.mousePosition.y - Screen.height / 2) / Screen.height * 2f;
        rb.velocity = speed * Time.deltaTime * movement;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Barrier"))
        {
            rb.velocity = Vector2.zero;
        }
    }
}
