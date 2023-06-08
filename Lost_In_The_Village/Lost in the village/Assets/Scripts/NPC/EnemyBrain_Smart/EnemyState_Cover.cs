using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class EnemyState_Cover : IState
{

    private EnemyReferences enemyReferences;
    private StateMachine stateMachine;
    private Transform target;
    public float spotingDistance = 40f;

    public EnemyState_Cover(EnemyReferences enemyReferences)
    {

        this.enemyReferences = enemyReferences;

        stateMachine = new StateMachine();

        var enemyShoot = new EnemyState_Shoot(enemyReferences);
        var enemyDelay = new EnemyState_Delay(1f);
        var enemyReload = new EnemyState_Reload(enemyReferences);

        At(enemyShoot, enemyReload, () => enemyReferences.shooter.ShouldReload());
        At(enemyReload, enemyDelay, () => !enemyReferences.shooter.ShouldReload());
        At(enemyDelay, enemyShoot, () => enemyDelay.IsDone());

        stateMachine.SetState(enemyShoot);

        void At(IState from, IState to, Func<bool> condition) => stateMachine.AddTransition(from, to, condition);
        void Any(IState to, Func<bool> condition) => stateMachine.AddAnyTransition(to, condition);

    }

    public bool PlayerInRange()
    {
        return Vector3.Distance(enemyReferences.transform.position, target.position) <= spotingDistance;
    }


    public Color GizmoColor()
    {
        return stateMachine.GetGizmoColor();
    }

    public void OnEnter()
    {
        target = GameObject.FindWithTag("Player").transform;
        enemyReferences.animator.SetBool("combat", true);
    }

    public void OnExit()
    {
        enemyReferences.animator.SetBool("combat", false);
    }


    public void Tick()
    {
        stateMachine.Tick();
    }
}
