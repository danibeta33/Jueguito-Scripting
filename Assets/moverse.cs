using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Animator animator;
    private float lastXPosition;
    private float lastYPosition;
    private float checkInterval = 0.1f;
    private float checkTimer = 0f;

    void Start()
    {
        animator = GetComponent<Animator>();
        lastXPosition = transform.position.x;
        lastYPosition = transform.position.y;
    }

    void Update()
    {
        checkTimer += Time.deltaTime;

        if (checkTimer >= checkInterval)
        {
            float currentX = transform.position.x;
            float currentY = transform.position.y;

            bool isRunning = Mathf.Abs(currentX - lastXPosition) > 0.001f;
            bool isJumping = Mathf.Abs(currentY - lastYPosition) > 0.001f;

            animator.SetBool("isrunning", isRunning);
            animator.SetBool("jumping", isJumping);

            lastXPosition = currentX;
            lastYPosition = currentY;
            checkTimer = 0f;
        }
    }
}
