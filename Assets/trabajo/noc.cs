using UnityEngine;
using MoreMountains.Tools;

namespace MoreMountains.CorgiEngine
{
    /// <summary>
    /// Este componente desactiva la habilidad del jetpack cuando es recogido
    /// </summary>
    [AddComponentMenu("Corgi Engine/Items/Pickable Jetpack Remover")]
    public class PickableJetpackRemover : PickableItem
    {
        /// <summary>
        /// Verifica si el objeto es recolectable (solo el jugador puede recogerlo)
        /// </summary>
        protected override bool CheckIfPickable()
        {
            _character = _pickingCollider.GetComponent<Character>();

            // Si no es un personaje o no es un jugador, no se puede recoger
            if (_character == null || _character.CharacterType != Character.CharacterTypes.Player)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Al recogerlo, desactiva la habilidad del jetpack
        /// </summary>
        protected override void Pick(GameObject picker)
        {
            _character.gameObject.MMGetComponentNoAlloc<CharacterJetpack>()?.PermitAbility(false);
        }
    }
}
