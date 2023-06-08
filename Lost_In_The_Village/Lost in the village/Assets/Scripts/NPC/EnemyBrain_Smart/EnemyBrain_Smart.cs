using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBrain_Smart : MonoBehaviour
{
    private EnemyReferences enemyReferences;

    private StateMachine stateMachine;

    private void Start()
    {
        enemyReferences = GetComponent<EnemyReferences>();

        stateMachine = new StateMachine();

        CoverArea coverArea = FindObjectOfType<CoverArea>();

        //States
        var patrol = new EnemyState_Patroling(enemyReferences, coverArea);
        var runToCover = new EnemyState_RunToCover(enemyReferences, coverArea);
        var patrolStop = new EnemyState_Wait(2f);
        var delayAfterRun = new EnemyState_Delay(1f);
        var cover = new EnemyState_Cover(enemyReferences);
        //Transitions
        At(patrol, runToCover, () => patrol.PlayerSpotted());
        At(patrol, patrolStop, () => patrol.HasArrivedAtDestination());
        At(patrolStop, patrol, () => patrolStop.IsDone());
        At(runToCover, delayAfterRun, () => runToCover.HasArrivedAtDestination());
        At(delayAfterRun, cover, () => delayAfterRun.IsDone());

        At(cover, patrolStop, () => !cover.PlayerInRange());


        //Start state
        stateMachine.SetState(patrol);

        //Functions
        void At(IState from, IState to, Func<bool> condition) => stateMachine.AddTransition(from, to, condition);
        void Any(IState to, Func<bool> condition) => stateMachine.AddAnyTransition(to, condition);

    }


    private void Update()
    {
        stateMachine.Tick();
    }

    private void OnDrawGizmos()
    {
        if (stateMachine != null)
        {
            Gizmos.color = stateMachine.GetGizmoColor();
            Gizmos.DrawSphere(transform.position + Vector3.up * 3, 0.4f);
        }
    }


}
