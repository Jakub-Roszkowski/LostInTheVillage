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
        var runToCover = new EnemyState_RunToCover(enemyReferences, coverArea);
        var delayAfterRun = new EnemyState_Delay(2f);
        var cover = new EnemyState_Cover(enemyReferences);


        stateMachine.SetState(runToCover);


        void At(IState from, IState to, Func<bool> condition) => stateMachine.AddTransition(from, to, condition);
        void Any(IState to, Func<bool> condition) => stateMachine.AddAnyTransition(to, condition);

        //Transitions
        At(runToCover, delayAfterRun, () => runToCover.HasArrivedAtDestination());
        At(delayAfterRun, cover, () => delayAfterRun.IsDone());

    }


    private void Update()
    {
        stateMachine.Tick();
    }


}
