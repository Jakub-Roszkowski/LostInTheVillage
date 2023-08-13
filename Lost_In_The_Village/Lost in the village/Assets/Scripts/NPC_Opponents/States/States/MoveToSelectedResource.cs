using UnityEngine;
using UnityEngine.AI;

internal class MoveToSelectedResource : IState
{
    private readonly Gatherer _gatherer;
    private readonly NavMeshAgent _navMeshAgent;
    private readonly Animator _animator;
    private static readonly int Speed = Animator.StringToHash("Speed");

    private Vector3 _lastPosition = Vector3.zero;
    
    public float TimeStuck;

    public MoveToSelectedResource(Gatherer gatherer, NavMeshAgent navMeshAgent, Animator animator)
    {
        _gatherer = gatherer;
        _navMeshAgent = navMeshAgent;
        _animator = animator;
    }
    
    public void Tick()
    {
        if (Vector3.Distance(_gatherer.transform.position, _lastPosition) <= 0f)
            TimeStuck += Time.deltaTime;

        _lastPosition = _gatherer.transform.position;
    }

    public void OnEnter()
    {
        TimeStuck = 0f;
        _navMeshAgent.enabled = true;
        _navMeshAgent.SetDestination(_gatherer.Target.transform.position);
        _animator.SetFloat(Speed, 1f);
    }

    public void OnExit()
    {
        _navMeshAgent.enabled = false;
        _animator.SetFloat(Speed, 0f);
    }
}