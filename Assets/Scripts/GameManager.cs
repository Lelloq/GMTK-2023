using EasyTransition;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private string transationId = "RectangleGrid";
     private TransitionManager transitionManager;

    // -----------------------------------------------------

    private void Awake()
    {
        Instance = this;
        transitionManager = FindAnyObjectByType<TransitionManager>();
        Time.timeScale = 1f;
    }


    //private void Start() => Character.OnPlayerDeath += Character_OnPlayerDeath;



    // -----------------------------------------------------


    //private void Character_OnPlayerDeath(object sender, System.EventArgs e)
    //{
      //  GameOver();
    //}


    public void GameOver()
    {

    }

    public void RestartGame() => transitionManager.LoadScene(SceneManager.GetActiveScene().name, transationId, 0);

    public void BackToMenu() => transitionManager.LoadScene("Menu", transationId, 0);


}
