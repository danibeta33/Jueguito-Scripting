using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class jugar : MonoBehaviour
{
    public void Jugarboton()
    {
        MMSceneLoadingManager.LoadScene("level1");
    }
}
