using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoToWine : MonoBehaviour
{

    private Animator animator;
























    [SerializeField] private Transform movePositionTransforms;

    [SerializeField] private Transform movePositionTransforms2;

    private NavMeshAgent navMeshAgent;
    private int currentDestinationIndex = 0;
    [SerializeField] private int avoidanceDistance = 5;
    private bool isAvoiding = false;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }
    public void MoveToDestination()
    {

        SetDestination();
        animator.SetBool("is_walk", true);

    }
    public void MoveToDestination2()
    {

        SetDestination2();
        animator.SetBool("is_walk", true);

    }





    private void Update()
    {
        if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
        {
            animator.SetBool("is_walk", false);
        }
    }

    private void SetDestination()
    {
        navMeshAgent.destination = movePositionTransforms.position;
    }
    private void SetDestination2()
    {
        navMeshAgent.destination = movePositionTransforms2.position;
    }


}
