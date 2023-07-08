using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    public void ChangeToScene (string sceneToChangeTo) 
    {
        Debug.Log("Changing Scenes");
        SceneManager.LoadScene(sceneToChangeTo);
    }
    public void Quit()
    {
        Debug.Log("App Quit");
        Application.Quit();
    }
    public void Update()
    {
        if(SceneManager.GetActiveScene().name == "Credits" && Input.anyKey)
        {
            ChangeToScene("Menu");
        }
    }
}
