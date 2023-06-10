using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyReferences : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;

    public Animator animator;

    public EnemyShooter shooter;

    public LayerMask whatIsGround;


    [Header("Stats")]
    public float pathUpdateDelay = 0.2f;
    
    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        shooter = GetComponent<EnemyShooter>();
    }


}
