using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHandler : MonoBehaviour
{
    public void ChangeToScene (string sceneToChangeTo) 
    {
        Application.LoadLevel(sceneToChangeTo);
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("App Quit");
    }
}
