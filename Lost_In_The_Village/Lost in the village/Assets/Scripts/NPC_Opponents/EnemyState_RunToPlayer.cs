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
        enemyReferences.navMeshAgent.SetDestination(player.transform.position);
        destination = player.transform.position;
        if (Vector3.Distance(enemyReferences.transform.position, destination) < 28f)
        {
            enemyReferences.navMeshAgent.ResetPath();
            return true;
        }
        else return false;
    }

    public Color GizmoColor()
    {
        return Color.blue;
    }
}
