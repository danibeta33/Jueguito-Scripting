using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class MostrarLogro : MonoBehaviour
{
    [SerializeField]
    private MMAchievementList listaLogros;

    [SerializeField]
    private List<GameObject> logros;

    void Start()
    {
        ocultarLogros();
    }

    public void Update()
    {
        actualizarEstadoLogros();
    }

    public void ocultarLogros()
    {
        foreach (GameObject logro in logros)
        {
            logro.SetActive(false);

        }

    }

    public void actualizarEstadoLogros()
    {
        int indice=0;

        foreach (MMAchievement achievement in MMAchievementManager.AchievementsList)
        {
            if (indice < logros.Count)
            {
                logros[indice++].SetActive(achievement.UnlockedStatus);
            }

        }

    }


}
