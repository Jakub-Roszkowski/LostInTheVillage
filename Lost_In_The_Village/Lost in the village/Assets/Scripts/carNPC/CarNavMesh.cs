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
        SetDestination();
    }

    private void Update()
    {
        if (!isAvoiding && navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
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
        if (collision.gameObject.CompareTag("car"))
        {
            StartCoroutine(AvoidCollision());
        }
    }

    private IEnumerator AvoidCollision()
    {
        isAvoiding = true;

        // Skrêcanie w lewo dla obu samochodów
        Quaternion targetRotation = Quaternion.LookRotation(-transform.right);
        float rotateTime = 1.0f;
        float elapsedTime = 0.0f;

        while (elapsedTime < rotateTime)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, elapsedTime / rotateTime);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Czekanie przez 2 sekundy
        yield return new WaitForSeconds(2.0f);

        // Powrót do normalnej trasy dla obu samochodów
        SetDestination();
        isAvoiding = false;
    }
}
