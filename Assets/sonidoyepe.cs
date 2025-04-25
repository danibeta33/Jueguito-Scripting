using MoreMountains.Tools;
using UnityEngine;

public class SonidoPorProximidad : MonoBehaviour
{
    public AudioSource sonido; // Arrastra aquí el AudioSource desde el Inspector

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && sonido != null)
        {
            sonido.Play();
            MMAchievementManager.UnlockAchievement("easterEgg");
        }
    }
}
