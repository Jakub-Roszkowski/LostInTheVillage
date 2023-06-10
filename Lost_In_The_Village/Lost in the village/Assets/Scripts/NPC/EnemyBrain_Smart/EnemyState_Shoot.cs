using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;
using Quaternion = UnityEngine.Quaternion;


public class EnemyState_Shoot : IState
{
    private EnemyReferences enemyReferences;
    private Transform target;

    public EnemyState_Shoot(EnemyReferences enemyReferences)
    {
        this.enemyReferences = enemyReferences;

    }

    public void OnEnter()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    public void OnExit()
    {
        enemyReferences.animator.SetBool("shooting", false);
        target = null;
    }

    public void Tick()
    {
        if (target != null)
        {
            Vector3 lookPos = target.position - enemyReferences.transform.position;
            lookPos.y = 0;

            Quaternion rotation = Quaternion.LookRotation(lookPos);

            enemyReferences.transform.rotation = Quaternion.Slerp(enemyReferences.transform.rotation, rotation, 0.2f);

            enemyReferences.animator.SetBool("shooting", true);
        }
    }




    public Color GizmoColor()
    {
        return Color.red;
    }
}
