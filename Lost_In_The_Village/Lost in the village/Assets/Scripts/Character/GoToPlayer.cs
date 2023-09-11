using UnityEngine;
using UnityEngine.AI;

namespace LostInTheVillage.Character
{
    public class GoToPlayer : MonoBehaviour
    {        
        [SerializeField] private Transform movePositionTransforms;

        public bool IsToGo { get; set; } = false;

        private Animator animator;
        private NavMeshAgent agent;

        private void Start()
        {
            agent = GetComponent<NavMeshAgent>();
            animator = GetComponent<Animator>();
        }

        private void Update()
        {
            Vector3 direction = movePositionTransforms.position - transform.position;
            direction.y = 0;

            if (IsToGo)
            {
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

            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 5f * Time.deltaTime);
        }
    }
}
