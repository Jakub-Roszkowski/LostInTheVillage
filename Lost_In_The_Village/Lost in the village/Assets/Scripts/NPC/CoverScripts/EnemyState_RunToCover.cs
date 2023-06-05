using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState_RunToCover : IState
{

    private EnemyReferences enemyReferences;
    private CoverArea coverArea;

    public EnemyState_RunToCover(EnemyReferences enemyReferences, CoverArea coverArea)
    {
        this.enemyReferences = enemyReferences;
        this.coverArea = coverArea;
    }

    public void OnEnter()
    {
        Cover nextCover = this.coverArea.GetRandomCover(enemyReferences.transform.position);
        enemyReferences.navMeshAgent.SetDestination(nextCover.transform.position);
    }


    public void OnExit()
    {
        enemyReferences.animator.SetFloat("speed", 0f);
    }

    public void Tick()
    {
        enemyReferences.animator.SetFloat("speed", enemyReferences.navMeshAgent.desiredVelocity.sqrMagnitude);
    }


}
