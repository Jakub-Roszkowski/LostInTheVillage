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

        var runToCover = new EnemyState_RunToCover(enemyReferences, coverArea);


        stateMachine.SetState(runToCover);


        void At(IState from, IState to, Func<bool> condition) => stateMachine.AddTransition(from, to, condition);
        void Any(IState to, Func<bool> condition) => stateMachine.AddAnyTransition(to, condition);

    }


    private void Update()
    {
        stateMachine.Tick();
    }


}
