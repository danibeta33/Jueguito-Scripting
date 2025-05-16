using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using MoreMountains.Tools;// Required to change scenes

public class CambioExcenaboton : MonoBehaviour
{
    public string sceneName; // Scene name to load, set in the Inspector

    // This function will be called when the button is pressed
    public void LoadScene()
    {
        MMSceneLoadingManager.LoadScene(sceneName);
    }
}
