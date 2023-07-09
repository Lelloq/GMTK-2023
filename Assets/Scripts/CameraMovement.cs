using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraMovement : MonoBehaviour
{
    public float speed = 5000f;
    public Transform lightTrans;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
    }

    private void FixedUpdate()
    {
        Vector2 movement = Input.mousePosition;
        lightTrans.position = new Vector3(Camera.main.ScreenToWorldPoint(movement).x, Camera.main.ScreenToWorldPoint(movement).y, 0);

        movement.x = (Input.mousePosition.x - Screen.width / 2) / Screen.width * 2f;
        movement.y = (Input.mousePosition.y - Screen.height / 2) / Screen.height * 2f;
        rb.velocity = speed * Time.deltaTime * movement;
    }
}
