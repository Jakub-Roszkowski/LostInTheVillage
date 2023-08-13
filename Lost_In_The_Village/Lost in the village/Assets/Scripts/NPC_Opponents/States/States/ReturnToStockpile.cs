using UnityEngine;
using UnityEngine.AI;

internal class ReturnToStockpile : IState
{
    private readonly Gatherer _gatherer;
    private readonly NavMeshAgent _navMeshAgent;
    private readonly Animator _animator;
    private static readonly int Speed = Animator.StringToHash("Speed");

    public ReturnToStockpile(Gatherer gatherer, NavMeshAgent navMeshAgent, Animator animator)
    {
        _gatherer = gatherer;
        _navMeshAgent = navMeshAgent;
        _animator = animator;
    }

    public void Tick()
    {
    }

    public void OnEnter()
    {
        _gatherer.StockPile = Object.FindObjectOfType<StockPile>();
        _navMeshAgent.enabled = true;
        _navMeshAgent.SetDestination(_gatherer.StockPile.transform.position);
        _animator.SetFloat(Speed, 1f);
    }

    public void OnExit()
    {
        _navMeshAgent.enabled = false;
        _animator.SetFloat(Speed, 0f);
    }
}