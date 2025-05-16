using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class obsequio : MonoBehaviour, MMEventListener<PickableItemEvent>
{
    public GameObject specialItem; // Objeto a activar cuando se alcancen los 120 puntos
    static public int puntos = 0;

    void OnEnable()
    {
        this.MMEventStartListening<PickableItemEvent>();
    }

    void OnDisable()
    {
        this.MMEventStopListening<PickableItemEvent>();
    }

    public virtual void OnMMEvent(PickableItemEvent e)
    {
        Coin coin = e.PickedItem.GetComponent<Coin>();
        if (coin != null)
        {
            puntos += coin.PointsToAdd;
            if (puntos >= 120 && specialItem != null)
            {
                specialItem.SetActive(true); // Activa el objeto
                MMAchievementManager.UnlockAchievement("jetpack");
            }
        }
    }
}