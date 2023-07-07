using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform cameraPos;
    public Rigidbody2D rb;

    public float speed = 5.0f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.MovePosition(speed * Time.deltaTime * cameraPos.position);
    }
}
