using UnityEngine;

public class LevelCompleteUI : MonoBehaviour
{
    private Animator animator;

    private const string GAMEOVER_FADEIN = "GameOverFadeIn";


    private void Awake()
    {
        animator = GetComponent<Animator>();

        Character.OnGameWon += Character_OnGameWon;

        Hide();
    }

    private void Character_OnGameWon(object sender, System.EventArgs e)
    {
        Show();
    }

    private void Show()
    {

        gameObject.SetActive(true);
        animator.SetTrigger(GAMEOVER_FADEIN);
    }


    private void Hide() => gameObject.SetActive(false);



    public void GameOver()
    {
        Time.timeScale = 0f;
    }

}
