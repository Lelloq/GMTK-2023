using UnityEngine;
using DG.Tweening;

public class PlayerFollowCamera : MonoBehaviour
{
    public Transform cameraPos;
    private Rigidbody2D playerRb;


    private void Awake() => playerRb = GetComponent<Rigidbody2D>();

    private void Update()
    {
        // Lag need to find alternative
        playerRb.MovePosition(cameraPos.position);
        // transform.position = new Vector3(cameraPos.position.x, cameraPos.position.y, transform.position.z);
    }
}
