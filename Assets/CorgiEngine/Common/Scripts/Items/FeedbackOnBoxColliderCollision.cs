using UnityEngine;
using MoreMountains.Feedbacks;

namespace MoreMountains.CorgiEngine
{
    [AddComponentMenu("Corgi Engine/Items/Feedback On BoxCollider Collision")]
    public class FeedbackOnBoxColliderCollision : MonoBehaviour
    {
        [Tooltip("El feedback a ejecutar cuando colisiona con un BoxCollider2D")]
        public MMFeedbacks CollisionFeedbacks;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider is BoxCollider2D)
            {
                CollisionFeedbacks?.PlayFeedbacks();
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other is BoxCollider2D)
            {
                CollisionFeedbacks?.PlayFeedbacks();
            }
        }
    }
}
