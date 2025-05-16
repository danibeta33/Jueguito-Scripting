using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class CambioEscenaContacto : MonoBehaviour
{
    public string sceneName; // Scene name to load, set in the Inspector

    void Start()
    {
        Debug.Log("CambioEscenaContacto script is running!");
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered the trigger has the tag "Player"
        
            MMSceneLoadingManager.LoadScene(sceneName); // Load the scene specified in the Inspector
        
    }
}