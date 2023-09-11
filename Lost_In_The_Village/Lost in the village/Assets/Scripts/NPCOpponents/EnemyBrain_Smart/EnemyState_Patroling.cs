using System;
using UnityEngine;
using Random = UnityEngine.Random;
using Vector3 = UnityEngine.Vector3;

namespace LostInTheVillage.NPCOpponents.States.EnemyBrainSmart
{
    public class EnemyState_Patroling : IState
    {
        private EnemyReferences enemyReferences;
        private CoverArea coverArea;
        public Vector3 destination;
        private Transform target;
        public float spottingDistance = 70f;

        private Cover currentCover = null;

        private StateMachine stateMachine;

        private bool walkPointSet = false;

        private int walkPointRange = 6;

        private Vector3 walkPoint;

        public EnemyState_Patroling(EnemyReferences enemyReferences, CoverArea coverArea)
        {
            this.enemyReferences = enemyReferences;
            this.coverArea = coverArea;

            stateMachine = new StateMachine();

            //Functions
            void At(IState from, IState to, Func<bool> condition) => stateMachine.AddTransition(from, to, condition);
            void Any(IState to, Func<bool> condition) => stateMachine.AddAnyTransition(to, condition);
        }

        public void OnEnter()
        {
            target = GameObject.FindWithTag("Player").transform;
            enemyReferences.animator.SetBool("shooting", false);
            enemyReferences.animator.SetBool("isWalking", true);
        }

        public void OnExit()
        {
            enemyReferences.animator.SetBool("isWalking", false);
            target = null;
        }

        public void Tick()
        {
            stateMachine.Tick();
            if (!PlayerSpotted())
            {
                if (!walkPointSet) SearchWalkPoint();
                if (walkPointSet) enemyReferences.navMeshAgent.SetDestination(walkPoint);

                Vector3 distanceToWalkPoint = enemyReferences.transform.position - walkPoint;

                if (distanceToWalkPoint.magnitude < 1f)
                {
                    walkPointSet = false;
                }
            }
        }

        private void SearchWalkPoint()
        {
            float randomZ = Random.Range(-walkPointRange, walkPointRange);
            float randomX = Random.Range(-walkPointRange, walkPointRange);

            walkPoint = new Vector3(enemyReferences.transform.position.x + randomX,
                enemyReferences.transform.position.y,
                enemyReferences.transform.position.z + randomZ);

            if (Physics.Raycast(walkPoint, -enemyReferences.transform.up, 2f, enemyReferences.whatIsGround))
            {
                walkPointSet = true;
            }
        }

        public bool PlayerSpotted()
        {
            return Vector3.Distance(enemyReferences.transform.position, target.position) <= spottingDistance;
        }

        public Color GizmoColor()
        {
            return Color.white;
        }
    }
}
