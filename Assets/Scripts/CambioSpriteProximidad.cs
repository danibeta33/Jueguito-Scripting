using UnityEngine;

public class CambioDeSpritePorProximidad : MonoBehaviour
{
    public GameObject sprite1; // Sprite que se activa al acercarse el jugador
    public GameObject sprite2; // Sprite que está activo por defecto

    void Start()
    {
        // Al iniciar el juego, sprite1 desactivado, sprite2 activado
        if (sprite1 != null) sprite1.SetActive(false);
        if (sprite2 != null) sprite2.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (sprite1 != null) sprite1.SetActive(true);
            if (sprite2 != null) sprite2.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (sprite1 != null) sprite1.SetActive(false);
            if (sprite2 != null) sprite2.SetActive(true);
        }
    }
}
