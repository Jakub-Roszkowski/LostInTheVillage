using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState_RunToPlayer : IState
{ 
    private EnemyReferences enemyReferences;
    private GameObject player;
    public Vector3 destination;

    public EnemyState_RunToPlayer(EnemyReferences enemyReferences, GameObject player)
    {
        this.enemyReferences = enemyReferences;
        this.player = player;
    }

    public void OnEnter()
    {
        enemyReferences.navMeshAgent.SetDestination(player.transform.position);
        destination = player.transform.position;
        enemyReferences.animator.SetBool("isWalking", false);
    }


    public void OnExit()
    {
        enemyReferences.animator.SetFloat("speed", 0f);

    }

    public void Tick()
    {
        enemyReferences.animator.SetFloat("speed", enemyReferences.navMeshAgent.desiredVelocity.sqrMagnitude);
    }

    public bool HasArrivedAtDestination()
    {
        return Vector3.Distance(enemyReferences.transform.position, destination) < 30f;
        //zmienilem z 0.5f
    }

    public Color GizmoColor()
    {
        return Color.blue;
    }
}
