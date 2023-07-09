using System.Collections;
using System.Collections.Generic;
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
    
    public GameObject GameOverUI;
    public GameObject LevelLoader;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Collided with Finish");
            GameOverUI.GetComponent<GameOverUI>().Show();
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            Debug.Log("Collided with Finish");
            LevelLoader.GetComponent<LevelLoader>().NextLevelLoad();
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
