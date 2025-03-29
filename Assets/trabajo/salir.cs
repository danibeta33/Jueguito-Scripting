using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class salir : MonoBehaviour
{
    public void Salir()
    {
        MMSceneLoadingManager.LoadScene("creditos");
    }
}
