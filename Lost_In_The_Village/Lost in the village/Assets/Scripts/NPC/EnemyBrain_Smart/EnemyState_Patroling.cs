using System;
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

    private Cover currentCover=null;

    private StateMachine stateMachine;
    


    public EnemyState_Patroling(EnemyReferences enemyReferences, CoverArea coverArea)
    {
        this.enemyReferences = enemyReferences;
        this.coverArea = coverArea;

        stateMachine = new StateMachine();

        var runToCover = new EnemyState_RunToCover(enemyReferences, coverArea);
        var patrolStop = new EnemyState_Wait(1.5f);
        var delayAfterCover = new EnemyState_CoverDelay(1f);


        //Any(patrolStop, () => HasArrivedAtDestination());
        //At(patrolStop, this, () => patrolStop.IsDone());
        //Any(runToCover, () => PlayerSpotted());


        //Functions
        void At(IState from, IState to, Func<bool> condition) => stateMachine.AddTransition(from, to, condition);
        void Any(IState to, Func<bool> condition) => stateMachine.AddAnyTransition(to, condition);


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

    public bool EndPatrol() {
        return PlayerSpotted() && HasArrivedAtDestination();
    }


    public Color GizmoColor()
    {
        return Color.white;
    }
}
