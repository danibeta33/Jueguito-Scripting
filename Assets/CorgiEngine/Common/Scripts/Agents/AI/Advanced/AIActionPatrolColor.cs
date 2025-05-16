using System.Collections;
using UnityEngine;
using MoreMountains.Tools;

namespace MoreMountains.CorgiEngine
{
    /// <summary>
    /// Acción de patrulla que cambia el color del sprite de rojo a normal en bucle mientras patrulla.
    /// </summary>
    [AddComponentMenu("Corgi Engine/Character/AI/Actions/AI Action Patrol Color")]
    public class AIActionPatrolColor : AIActionPatrol
    {
        [Header("Color Change")]
        [Tooltip("El color a aplicar mientras patrulla.")]
        public Color PatrolColor = Color.red;
        [Tooltip("Duración de cada ciclo de cambio de color (segundos)")]
        public float ColorChangeDuration = 0.5f;

        protected SpriteRenderer _spriteRenderer;
        protected Color _originalColor;
        protected Coroutine _colorCoroutine;

        public override void Initialization()
        {
            base.Initialization();
            if (_spriteRenderer == null)
            {
                _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
                if (_spriteRenderer != null)
                {
                    _originalColor = _spriteRenderer.color;
                }
            }
        }

        public override void OnEnterState()
        {
            base.OnEnterState();
            if (_spriteRenderer != null && _colorCoroutine == null)
            {
                _colorCoroutine = StartCoroutine(ColorLoopCoroutine());
            }
        }

        public override void OnExitState()
        {
            base.OnExitState();
            if (_spriteRenderer != null)
            {
                if (_colorCoroutine != null)
                {
                    StopCoroutine(_colorCoroutine);
                    _colorCoroutine = null;
                }
                _spriteRenderer.color = _originalColor;
            }
        }

        protected IEnumerator ColorLoopCoroutine()
        {
            float timer = 0f;
            while (true)
            {
                timer += Time.deltaTime;
                float t = Mathf.PingPong(timer, ColorChangeDuration) / ColorChangeDuration;
                _spriteRenderer.color = Color.Lerp(_originalColor, PatrolColor, t);
                yield return null;
            }
        }
    }
}
