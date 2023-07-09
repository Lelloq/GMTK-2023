using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake() => Instance = this;


    public void GameOver()
    {
        Debug.Log("Game Over!");
    }
}
