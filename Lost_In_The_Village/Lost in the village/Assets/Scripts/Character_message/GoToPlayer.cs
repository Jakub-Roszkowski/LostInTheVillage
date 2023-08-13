using UnityEngine;
using UnityEngine.AI;

public class GoToPlayer : MonoBehaviour
{
    private Animator animator;
    private NavMeshAgent agent;

    public bool isToGo = false;

    [SerializeField] private Transform movePositionTransforms;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        isToGo = false;
    }

    private void Update()
    {
        if (isToGo)
        {
            Vector3 direction = movePositionTransforms.position - transform.position;

            if (direction.magnitude > agent.stoppingDistance)
            {
                agent.destination = movePositionTransforms.position;
                animator.SetBool("is_walk", true);
            }
            else
            {
                agent.ResetPath();
                animator.SetBool("is_walk", false);
            }
        }

        if (movePositionTransforms != null)
        {
            Vector3 direction = movePositionTransforms.position - transform.position;
            direction.y = 0;
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 5f * Time.deltaTime);
        }
    }
}
