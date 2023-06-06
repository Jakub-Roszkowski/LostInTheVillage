using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class EnemyState_RunToCover : IState
{

    private EnemyReferences enemyReferences;
    private CoverArea coverArea;
    private Vector3 destination;

    public EnemyState_RunToCover(EnemyReferences enemyReferences, CoverArea coverArea)
    {
        this.enemyReferences = enemyReferences;
        this.coverArea = coverArea;
    }

    public void OnEnter()
    {
        Debug.Log("onEnter");
        Cover nextCover = this.coverArea.GetRandomCover(enemyReferences.transform.position);
        enemyReferences.navMeshAgent.SetDestination(nextCover.transform.position);
        destination = nextCover.transform.position;
    }


    public void OnExit()
    {
        enemyReferences.animator.SetFloat("speed", 0f);
        Debug.Log("OnExit runToCover");
    }

    public void Tick()
    {
        enemyReferences.animator.SetFloat("speed", enemyReferences.navMeshAgent.desiredVelocity.sqrMagnitude);

    }

    public bool HasArrivedAtDestination()
    {
        return Vector3.Distance(enemyReferences.transform.position, destination) < 0.5f;
    }

    public Color GizmoColor()
    {
        return Color.blue;
    }
}
