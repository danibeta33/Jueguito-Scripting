using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class nivel2 : MonoBehaviour
{
    public string sceneName; // Scene name to load, set in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) // Check if the entering object has the "Player" tag
        {
            MMSceneLoadingManager.LoadScene(sceneName); // Load the scene specified in the Inspector
        }
    }
}