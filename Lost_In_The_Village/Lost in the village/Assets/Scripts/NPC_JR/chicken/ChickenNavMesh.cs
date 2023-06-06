using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChickenNavMesh : MonoBehaviour
{
    [SerializeField] private List<Transform> movePositionTransforms = new List<Transform>();

    private NavMeshAgent navMeshAgent;
    private int currentDestinationIndex = 0;
    [SerializeField] private int avoidanceDistance = 5;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        SetDestination();
    }

    private void Update()
    {
        if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
        {
            currentDestinationIndex = (currentDestinationIndex + 1) % movePositionTransforms.Count;
            SetDestination();
        }
    }

    private void SetDestination()
    {
        navMeshAgent.destination = movePositionTransforms[currentDestinationIndex].position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("chicken"))
        {
            // Odbicie od innego kurczaka
            Vector3 avoidanceDirection = transform.position - collision.transform.position;
            navMeshAgent.destination = transform.position + avoidanceDirection.normalized * avoidanceDistance;
        }
    }
}
