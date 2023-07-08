using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    public void ChangeToScene (string sceneToChangeTo) 
    {
        SceneManager.LoadScene(sceneToChangeTo);
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("App Quit");
    }
}
