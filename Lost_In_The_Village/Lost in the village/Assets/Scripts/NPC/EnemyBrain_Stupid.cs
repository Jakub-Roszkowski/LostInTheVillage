using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBrain_Stupid : MonoBehaviour
{
    public Transform target;

    EnemyReferences enemyReferences;

    private float shootingDistance;

    private float pathUpdateDeadline;

    private void Awake()
    {
        enemyReferences = GetComponent<EnemyReferences>();

    }

    private void Start()
    {
        shootingDistance = enemyReferences.navMeshAgent.stoppingDistance;

    }

    private void Update()
    {
        if(target != null)
        {
            bool inRange = Vector3.Distance(transform.position, target.position) <= shootingDistance;

            if (inRange)
            {
                LookAtTarget();
            }
            else
            {
                UpdatePath();
            }
            enemyReferences.animator.SetBool("shooting", inRange);

        }
        enemyReferences.animator.SetFloat("speed", enemyReferences.navMeshAgent.desiredVelocity.sqrMagnitude);
    }


    private void LookAtTarget()
    {
        Vector3 lookPos = target.position - transform.position;
        lookPos.y = 0;

        Quaternion rotation = Quaternion.LookRotation(lookPos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 0.2f);
    }

    private void UpdatePath()
    {
        if(Time.time >= pathUpdateDeadline)
        {
            pathUpdateDeadline = Time.time + enemyReferences.pathUpdateDelay;
            enemyReferences.navMeshAgent.SetDestination(target.position);
        }
    }
}
