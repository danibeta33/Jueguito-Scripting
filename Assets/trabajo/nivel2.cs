using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class nivel2 : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        MMSceneLoadingManager.LoadScene("Menu"); // Reemplaza con el nombre de la escena deseada
    }
}