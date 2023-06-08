using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using UnityEngine;
using Debug = UnityEngine.Debug;
using Vector3 = UnityEngine.Vector3;

public class EnemyState_Patroling : IState
{
    private EnemyReferences enemyReferences;
    private CoverArea coverArea;
    Vector3 destination;
    private Transform target;
    public float spottingDistance = 40f;

    bool isReturning = false;
    private Cover currentCover=null;

    public EnemyState_Patroling(EnemyReferences enemyReferences, CoverArea coverArea)
    {
        this.enemyReferences = enemyReferences;
        this.coverArea = coverArea;
    }

    public void OnEnter()
    {
        currentCover = this.coverArea.GetNearestCover(enemyReferences.transform.position,currentCover);
        enemyReferences.navMeshAgent.SetDestination(currentCover.transform.position);
        destination = currentCover.transform.position;
        target = GameObject.FindWithTag("Player").transform;
        enemyReferences.animator.SetBool("shooting", false);
    }

    public void OnExit()
    {
        enemyReferences.animator.SetBool("isWalking", false);
        target = null;

    }

    public void Tick()
    {
        enemyReferences.animator.SetBool("isWalking", true);
    }


    public bool HasArrivedAtDestination()
    {
        return Vector3.Distance(enemyReferences.transform.position, destination) < 0.5f;
    }

    public bool PlayerSpotted()
    {
        return Vector3.Distance(enemyReferences.transform.position, target.position) <= spottingDistance;
    }

    public Color GizmoColor()
    {
        return Color.white;
    }
}
