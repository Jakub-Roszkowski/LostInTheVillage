using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState_CoverDelay : IState
{

    private float waitForSeconds;
    private float deadline;

    public EnemyState_CoverDelay(float waitForSeconds)
    {
        this.waitForSeconds = waitForSeconds;
    }

    public void OnEnter()
    {
        deadline = Time.time + waitForSeconds;

    }

    public void OnExit()
    {

    }

    public void Tick()
    {
    }

    public bool IsDone()
    {
        return Time.time >= deadline;
    }

    public Color GizmoColor()
    {
        return Color.yellow;
    }
}
