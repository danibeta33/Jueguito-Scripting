using UnityEngine;
using UnityEngine.SceneManagement;
using MoreMountains.Tools;

namespace MoreMountains.CorgiEngine
{
    [AddComponentMenu("Corgi Engine/Items/Cambio Escena Colision")]
    public class CambioEscenaColision : MonoBehaviour
    {
        [Tooltip("Nombre de la escena a cargar al colisionar")] 
        public string SceneToLoad = "";

        private void OnCollisionEnter2D(Collision2D collision)
        {
            CambiarEscena();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            CambiarEscena();
        }

        private void CambiarEscena()
        {
            if (!string.IsNullOrEmpty(SceneToLoad))
            {
                try
                {
                    MoreMountains.Tools.MMSceneLoadingManager.LoadScene(SceneToLoad);
                }
                catch (System.Exception)
                {
                    UnityEngine.SceneManagement.SceneManager.LoadScene(SceneToLoad);
                }
            }
        }
    }
}
