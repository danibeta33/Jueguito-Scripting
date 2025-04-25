using System.Collections;
using System.Collections.Generic;
using MoreMountains.Tools;
using UnityEngine;

public class nivelFacil : MonoBehaviour
{
    public void cambiarFacil()
    { 
        MMSceneLoadingManager.LoadScene("Nivel 3");
    }
}
