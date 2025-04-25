using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class desactivarObjeto : MonoBehaviour, MMEventListener<PickableItemEvent>
{
    public GameObject objetoADesactivar;
    public GameObject objetoAActivar;// Objeto a desactivar cuando se alcancen los 200 puntos
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
            if (puntos >= 1000 && objetoADesactivar != null && objetoADesactivar.activeSelf)
            {
                objetoADesactivar.SetActive(false);
                objetoAActivar.SetActive(true);// Desactiva el objeto
                MMAchievementManager.UnlockAchievement("jetpack");
            }
        }
    }
}
