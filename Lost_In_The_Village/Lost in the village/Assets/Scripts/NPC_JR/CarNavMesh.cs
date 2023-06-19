using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CarNavMesh : MonoBehaviour
{
    [SerializeField] private List<Transform> movePositionTransforms = new List<Transform>();

    private NavMeshAgent navMeshAgent;
    private int currentDestinationIndex = 0;
    [SerializeField] private int avoidanceDistance = 5;
    private bool isAvoiding = false;

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
        if (!isAvoiding && navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
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
        if (collision.gameObject.CompareTag("car"))
        {
            StartCoroutine(AvoidCollision());
        }
    }

    private IEnumerator AvoidCollision()
    {
        isAvoiding = true;


        Quaternion targetRotation = Quaternion.LookRotation(-transform.right);
        float rotateTime = 1.0f;
        float elapsedTime = 0.0f;

        while (elapsedTime < rotateTime)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, elapsedTime / rotateTime);
            elapsedTime += Time.deltaTime;
            yield return null;
        }


        yield return new WaitForSeconds(1.0f);

        SetRandomDestination();
        isAvoiding = false;
    }
}

