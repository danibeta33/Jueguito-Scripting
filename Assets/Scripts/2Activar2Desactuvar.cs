using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class GestionObjetosPorPuntos : MonoBehaviour, MMEventListener<PickableItemEvent>
{
    public GameObject objeto1;
    public GameObject objeto2;
    public GameObject objeto4;
    public GameObject objeto5;

    static public int puntos = 0;
    private bool cambioRealizado = false;

    void Start()
    {
        // Estado inicial
        if (objeto1 != null) objeto1.SetActive(true);
        if (objeto4 != null) objeto4.SetActive(true);
        if (objeto2 != null) objeto2.SetActive(false);
        if (objeto5 != null) objeto2.SetActive(false);
    }

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

            if (puntos >= 500 && !cambioRealizado)
            {
                // Cambiar el estado de los objetos
                if (objeto1 != null) objeto1.SetActive(false);
                if (objeto4 != null) objeto4.SetActive(false);
                if (objeto2 != null) objeto2.SetActive(true);
                if (objeto5 != null) objeto5.SetActive(true);

                cambioRealizado = true;
            }
        }
    }
}
