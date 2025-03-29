using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class reiniciarjuego : MonoBehaviour
{
    [SerializeField]
    private string nombreEscena;

    public void Reiniciar()
    {
        if(nombreEscena == null)
        {
            Debug.LogError("escena no encontrada");
        }
        MMSceneLoadingManager.LoadScene(nombreEscena);
    }
}
