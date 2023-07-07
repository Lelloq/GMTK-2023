using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform cameraPos;
    private Rigidbody2D rb;

    public float speed = 25f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.MovePosition(cameraPos.position);
    }
}
