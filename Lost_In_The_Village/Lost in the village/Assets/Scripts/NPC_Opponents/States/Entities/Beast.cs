using UnityEngine;
using UnityEngine.AI;

public class Beast : MonoBehaviour
{
    [SerializeField] private Transform[] _destinations;
    private NavMeshAgent _navMeshAgent;
    private int _index;

     private void Awake()
     {
         _navMeshAgent = GetComponent<NavMeshAgent>();
     }
    
     private void Update()
     {
         if (_navMeshAgent.remainingDistance < 1f)
         {
             var nextDestination = GetNextDestination();
             _navMeshAgent.SetDestination(nextDestination);
         }
     }
    
     private Vector3 GetNextDestination()
     {
         _index++;
         if (_index >= _destinations.Length)
             _index = 0;
    
         return _destinations[_index].position;
     }
}