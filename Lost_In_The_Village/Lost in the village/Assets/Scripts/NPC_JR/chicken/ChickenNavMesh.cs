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
        SetRandomDestination();
    }

    private void Update()
    {
        if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
        {
            SetRandomDestination();
        }
    }

    private void SetRandomDestination()
    {
        int randomIndex = Random.Range(0, movePositionTransforms.Count);
        currentDestinationIndex = randomIndex;
        navMeshAgent.destination = movePositionTransforms[currentDestinationIndex].position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("chicken"))
        {
            Vector3 avoidanceDirection = transform.position - collision.transform.position;
            navMeshAgent.destination = transform.position + avoidanceDirection.normalized * avoidanceDistance;
        }
    }
}
