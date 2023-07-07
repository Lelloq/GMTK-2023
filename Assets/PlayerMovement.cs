using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0.5f; 

    private Rigidbody2D rb;

    private float range = 0.0f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
        
    }

    private void Update()
    {
        range = range + Time.deltaTime;

        if (range > 0.1f)
        {
            Event e = Event.current;
            range = 0.0f;
        }


        Vector2 movement = Input.mousePosition;
        movement.x = Input.mousePosition.x - Screen.width / 2;
        movement.y = Input.mousePosition.y - Screen.height / 2;
        rb.velocity = movement * speed * Time.deltaTime;
        Debug.Log(rb.velocity);
        Debug.Log(movement);
        Debug.Log(speed);
        Debug.Log(Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("SOLID"))
        {
            rb.velocity = Vector2.zero;
        }
    }
}
