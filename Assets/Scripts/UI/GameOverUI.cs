using System.Threading.Tasks;
using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    private Animator animator;

    private const string GAMEOVER_FADEIN = "GameOverFadeIn";


    private void Awake()
    {
        animator = GetComponent<Animator>();
        Hide();
    }

    public void Show()
    {
        gameObject.SetActive(true);
        animator.SetTrigger(GAMEOVER_FADEIN);
    }


    private void Hide() => gameObject.SetActive(false);



    public void GameOver()
    {
        Time.timeScale = 0f;
    }


    private void OnDestroy()
    {
        //Character.OnPlayerDeath -= Character_OnPlayerDeath;
    }
}
