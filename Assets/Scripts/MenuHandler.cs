using EasyTransition;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    private void Awake() => Time.timeScale = 1.0f;

    [SerializeField] private string transationId = "RectangleGrid";
    [SerializeField] private TransitionManager transitionManager;

    public void ChangeToScene(string sceneToChangeTo)
    {
        transitionManager.LoadScene(sceneToChangeTo, transationId, 0);
    }
    public void Update()
    {
        if (SceneManager.GetActiveScene().name == "Credits" && Input.anyKey)
        {
            ChangeToScene("Menu");
        }
    }



    public void Quit() => Application.Quit();
}
